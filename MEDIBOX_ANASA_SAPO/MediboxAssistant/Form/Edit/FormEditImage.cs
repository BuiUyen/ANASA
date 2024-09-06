using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Medibox.Model;
using Medibox.Presenter;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sanita.Utility;
using Sanita.Utility.ExtendedThread;
using Sanita.Utility.UI;




namespace Medibox
{
    public partial class FormEditImage : FormBase
    {
        private const String TAG = "FormEditImage";
        private bool isOK = true;
        private DialogResult result = DialogResult.Cancel;


        public class Sanpham
        {
            public string SKU { get; set; } // tổng số lượng sản phẩm
            
            public List<String> ListImage { get; set; } = new List<String>();
        }


        int stt = 0;

        ChromeDriver driver;

        //Private
        private FormProgress mProgress = new FormProgress();
        private ExBackgroundWorker mThread;
        
        private IList<Variant> mListVariant = new List<Variant>();
        private IList<Product> mListProduct = new List<Product>();
        private IList<Image> mListImage = new List<Image>();

        private enum ProcessingType
        {
            SaveData,
        }

        public FormEditImage(Product _mProduct, IList<Product> _mListProduct)
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
            mListVariant = VariantPresenter.GetVariants();
            mListImage = ImagePresenter.GetImages();

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
                
            }
            catch
            {
            }

        }

        private void bwAsync_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //mProgress.DoClose();
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
                        
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, System.Windows.Forms.Keys keyData)
        {
            switch (keyData)
            {
                case System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S:
                    
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Database_Load(object sender, EventArgs e)
        {

        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate
            //if (String.IsNullOrEmpty(txtDeviceCode.Text.Trim()))
            //{
            //    SanitaMessageBox.Show("Chưa nhập code !", "Thông Báo".Translate());
            //    txtDeviceCode.Focus();
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

        

        private void btnRun_Click(object sender, EventArgs e)
        {
            List<Sanpham> mListKetQua = new List<Sanpham>();
            foreach (string line in tbxInputSKU.Lines)
            {
                string text = line.Trim();
                if (text == "")
                {
                    Sanpham _linhkien = new Sanpham();
                    _linhkien.ListImage.Add("chưa có ảnh");
                    _linhkien.SKU = "Lỗi SKU";
                    mListKetQua.Add(_linhkien);
                }
                else
                {
                    Sanpham _linhkien = new Sanpham();
                    _linhkien.SKU = text;
                    Variant var = mListVariant.FirstOrDefault(v => v.sku == text);

                    List<Image> _listimage = new List<Image>();
                    foreach(Image ima in mListImage)
                    {
                        if(ima.product_id == var.product_id)
                        {
                            _listimage.Add(ima);
                        }
                    }

                    _listimage.Sort((x, y) => x.position.CompareTo(y.position));

                    foreach (Image ima in _listimage)
                    {
                        _linhkien.ListImage.Add(ima.full_path);
                    }

                    mListKetQua.Add(_linhkien);
                }
            }



            dataGridViewKetQua.Rows.Clear();
            foreach (Sanpham sp in mListKetQua)
            {
                int n = dataGridViewKetQua.Rows.Add();
                dataGridViewKetQua.Rows[n].Cells[0].Value = sp.SKU;               
                for (int i = 0; i < sp.ListImage.Count && i < 10 ; i++)
                {
                    dataGridViewKetQua.Rows[n].Cells[i+1].Value = sp.ListImage[i];

                }                
            }





        }
    }
}