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
using OpenQA.Selenium.Chrome;
using Sanita.Utility;
using Sanita.Utility.ExtendedThread;
using Sanita.Utility.UI;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;

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

            int tong = 0;
            foreach (Checker checker in mListChecker)
            {
                Int32.TryParse(checker.Name, out int t);
                tong = tong + t;
            }
            label1.Text = tong.ToString();
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


        string folderPath = @"E:\XXX3";

        string link_server = @"https://img.xchina.biz/photos/";
        string link_server1 = @"https://img.xchina.biz/photos1/";
        string link_server2 = @"https://img.xchina.biz/photos2/";


        private void btnRun_Click(object sender, EventArgs e)
        {

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //options.AddArgument("--window-position=-32000,-32000"); //an chorme
            var driver = new ChromeDriver(driverService, options);
            driver.Navigate().GoToUrl("https://www.google.com/");
            System.Threading.Thread.Sleep(15000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());


            foreach (Checker _checker in mListChecker)
            {
                int i = 1;
                {
                    if (_checker.Name == "0")
                    {
                        string _linksever = "";
                        List<String> mlist = new List<string> { link_server, link_server1, link_server2 };

                        foreach (string item in mlist)
                        {
                            _linksever = item;
                            driver.Navigate().GoToUrl(_linksever + _checker.CheckerCode + "/0001.jpg");
                            System.Threading.Thread.Sleep(200);

                            DowloadImage(driver, _checker.CheckerCode + "_1", _linksever + _checker.CheckerCode + "/0001.jpg");
                            System.Threading.Thread.Sleep(5000);

                            if (System.IO.File.Exists(folderPath + @"\" + _checker.CheckerCode + "_1.jpg"))
                            {
                                break;
                            }
                        }

                        if (System.IO.File.Exists(folderPath + @"\" + _checker.CheckerCode + "_1.jpg"))
                        {
                            int dem = 1;
                            i = 2;
                            do
                            {
                                try
                                {
                                    string Alt = _checker.CheckerCode + "_" + i; //tên ảnh                                
                                    string link = _linksever + _checker.CheckerCode + "/" + i.ToString("0000") + ".jpg";//link ảnh

                                    driver.Navigate().GoToUrl(link);
                                    System.Threading.Thread.Sleep(200);

                                    DowloadImage(driver, Alt, link);

                                    if(dem == 25)
                                    {
                                        dem = 1;
                                        System.Threading.Thread.Sleep(3000);
                                        if (!System.IO.File.Exists(folderPath + @"\" + _checker.CheckerCode + "_" + (i - 25).ToString() + ".jpg"))
                                        {
                                            break;
                                        }

                                    }
                                    dem++;

                                    
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi tải ảnh: " + _checker.CheckerCode, "Thông Báo");
                                    MessageBox.Show(ex.ToString());
                                    break;
                                }
                                i++;
                            }
                            while (i < 1500);
                            System.Threading.Thread.Sleep(5000);
                        }

                        else
                        {
                            _checker.Phone = "0";
                            CheckerPresenter.UpdateChecker(_checker);
                        }



                    }
                }
            }




        }

        private void DowloadImage(ChromeDriver driver, string Alt, string link)
        {

            string script = @"              var link = document.createElement('a');
                                            link.href = arguments[0];
                                            link.download = '" + Alt + @".jpg';
                                            document.body.appendChild(link);
                                            link.click();
                                            document.body.removeChild(link);
                                            ";
            // Thực thi tập lệnh JavaScript để tải hình ảnh xuống
            ((IJavaScriptExecutor)driver).ExecuteScript(script, link);
            System.Threading.Thread.Sleep(800);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = mListChecker.FirstOrDefault(x => x.CheckerCode == textBox1.Text).Phone.ToString();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (Checker _checker in mListChecker)
            {                
                if (System.IO.File.Exists(@"F:\Xchina\" + _checker.CheckerCode + "_1.jpg"))
                {
                    int dem = 1;
                    for (int j = 2; j < 3000; j++)
                    {
                        if (System.IO.File.Exists(@"F:\Xchina\" + _checker.CheckerCode + "_" + j.ToString() + ".jpg"))
                        {
                            dem++;
                        }
                        else
                        {

                        }
                    }
                    _checker.Name = dem.ToString();
                    CheckerPresenter.UpdateChecker(_checker);
                }
                else
                {
                    _checker.Name = "0";
                    CheckerPresenter.UpdateChecker(_checker);
                }

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Đường dẫn tới thư mục chứa profile của Chrome
            string userProfile = @"C:\Users\huuuy\AppData\Local\Google\Chrome\User Data";

            // Tên của profile bạn muốn sử dụng
            //string profileName = "Default"; 
            string profileName = "Profile 2";

            // Cấu hình ChromeOptions để sử dụng profile đã lưu
            var options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userProfile}");
            options.AddArgument($"--profile-directory={profileName}");

            // Thay đổi User-Agent
            options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

            // Thêm các cờ tùy chọn để tránh bị phát hiện
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");

            // Khởi động Chrome với cấu hình đã thiết lập
            IWebDriver driver = new ChromeDriver(options);

            // Ẩn thuộc tính webdriver
            ((IJavaScriptExecutor)driver).ExecuteScript("Object.defineProperty(navigator, 'webdriver', {get: () => undefined})");

            // Mở trang web bất kỳ
            driver.Navigate().GoToUrl("https://www.google.com");

            // Giữ trình duyệt mở để bạn có thể xem kết quả
            //Console.WriteLine("Press any key to close the browser...");
            //Console.ReadKey();

            // Đóng trình duyệt
            //driver.Quit();

        }
    }
}