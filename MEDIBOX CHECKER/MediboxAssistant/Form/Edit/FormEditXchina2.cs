using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using ExcelDataReader;
using Medibox.Database;
using Medibox.Model;
using Medibox.Presenter;
using OpenQA.Selenium;
using Sanita.Utility;
using Sanita.Utility.ExtendedThread;
using Sanita.Utility.UI;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Medibox
{
    public partial class FormEditXchina2 : FormBase
    {
        private const String TAG = "FormEditXchina";

        public Checker mChecker = new Checker();

        DataTableCollection tableCollection;

        //Private
        private FormProgress mProgress = new FormProgress();
        private ExBackgroundWorker mThread;
        private IList<Checker> mListChecker = new List<Checker>();
        

        private enum ProcessingType
        {
            SaveData,
        }

        public FormEditXchina2(Checker _mChecker, IList<Checker> _mListChecker)
        {
            InitializeComponent();
            this.Translate();
            this.UpdateUI();
            base.DoInit();

            //Create worker
            mThread = new ExBackgroundWorker();
            mThread.WorkerReportsProgress = true;
            mThread.WorkerSupportsCancellation = true;
            mThread.ProgressChanged += new ProgressChangedEventHandler(bwAsync_WorkerChanged);
            mThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwAsync_WorkerCompleted);
            mThread.DoWork += new DoWorkEventHandler(bwAsync_Worker);

            mChecker = _mChecker ?? new Checker();
            mListChecker = _mListChecker;

        }

        #region Worker thread

        private void bwAsync_Start(ProcessingType type)
        {
            if (!mThread.IsBusy)
            {
                mThread.RunWorkerAsync(type);
            }
        }

        private void bwAsync_WorkerChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.ProgressPercentage == -123456)
                {
                    mProgress = new FormProgress();
                    mProgress.Progress.TextVisible = false;
                    mProgress.ShowDialog();
                }
                else if (e.ProgressPercentage == 0)
                {
                    mProgress.Progress.Value = 0;
                    mProgress.Progress.Maximum = (int)e.UserState;
                }
                else if (e.ProgressPercentage > 0)
                {
                    mProgress.Progress.Value = e.ProgressPercentage;
                    mProgress.Progress.Text = string.Format("{0}%", (mProgress.Progress.Value * 100) / mProgress.Progress.Maximum);
                }
                else if (e.ProgressPercentage < 0)
                {
                    SanitaMessageBox.Show("Có lỗi xảy ra !", "Thông Báo".Translate());
                }
            }
            catch
            {
            }
        }

        private void bwAsync_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mProgress.DoClose();
            ProcessingType type = (ProcessingType)e.Result;

            switch (type)
            {
                case ProcessingType.SaveData:
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void bwAsync_Worker(object sender, DoWorkEventArgs e)
        {
            ProcessingType type = (ProcessingType)e.Argument;
            e.Result = type;

            switch (type)
            {
                case ProcessingType.SaveData:
                    {
                        //if (mChecker.CheckerID > 0)
                        //{
                        //    CheckerPresenter.UpdateChecker(mChecker);
                        //}
                        //else
                        //{
                        //    CheckerPresenter.InsertChecker(mChecker);
                        //}
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        

        private void Database_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate
            //if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            //{
            //    SanitaMessageBox.Show("Chưa nhập code !", "Thông Báo".Translate());                
            //    return;
            //}
            bwAsync_Start(ProcessingType.SaveData);
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 0x0D)
            {
                SendKeys.SendWait("{TAB}");
            }
        }


        string folderPath = @"F:\Xchina";
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            foreach(Checker _checker in mListChecker)
            {
                int i = 1;
                if(_checker.Name == "")
                {
                    do
                    {
                        try
                        {
                            string Alt = _checker.CheckerCode + "_" + i; //tên ảnh
                            string Path = folderPath + @"\" + _checker.CheckerCode;  //đường dẫn thư mục lưu ảnh
                            try
                            {
                                // Kiểm tra nếu thư mục không tồn tại, thì tạo mới
                                if (!Directory.Exists(Path))
                                {
                                    Directory.CreateDirectory(Path);
                                }
                                else
                                {
                                    //Console.WriteLine("Thư mục đã tồn tại.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi khi tạo thư mục: " + ex.Message, "Thông Báo");
                            }

                            string link = @"https://img.xchina.biz/photos2/" + _checker.CheckerCode + "/" + i.ToString("0000") + ".jpg";
                            string savePath = Path + @"\" + Alt + ".jpg";


                            using (WebClient client = new WebClient())
                            {
                                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                                client.Headers.Add("User-Agent", "PostmanRuntime/7.26.1");
                                client.DownloadFile(link, savePath);
                                System.Threading.Thread.Sleep(1000);
                            }
                                                        

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi tải ảnh: " + _checker.CheckerCode, "Thông Báo");
                            MessageBox.Show(ex.ToString());
                            break;
                        }
                        i++;

                    }
                    while (i < 500);
                    
                }
            }          
            
           

        }
        

    }
}