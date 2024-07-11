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
    public partial class FormEditProduct : FormBase
    {
        private const String TAG = "FormEditProduct";

        public class Root
        {
            public Metadata metadata { get; set; }
            public List<Product> products { get; set; }
        }

        public class Metadata
        {
            public int total { get; set; } // tổng số lượng sản phẩm
            public int page { get; set; } // đánh số trang
            public int limit { get; set; }// giới hạn số lượng sản phẩm trên trang
        }

        public Product product = new Product();
        public Root root = new Root();

        ChromeDriver driver;

        //Private
        private FormProgress mProgress = new FormProgress();
        private ExBackgroundWorker mThread;
        private IList<Device> mListDevice = new List<Device>();

        private enum ProcessingType
        {
            SaveData,
        }

        public FormEditProduct(Device _mDevice, IList<Device> _mListDevice)
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
                        //if (mDevice.DeviceID > 0)
                        //{
                        //    DevicePresenter.UpdateDevice(mDevice);
                        //}
                        //else
                        //{
                        //    DevicePresenter.InsertDevice(mDevice);
                        //}
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
                    btnOK_Click(this, null);
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Database_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //options.AddArgument("--window-position=-32000,-32000"); //an chorme
            //options.AddArgument("headless");

            driver = new ChromeDriver(driverService, options);
            driver.Navigate().GoToUrl("https://anasa.mysapogo.com/");
            driver.FindElementById("username").SendKeys("0327006111");
            driver.FindElementById("password").SendKeys("@Uyen23071998");
            driver.FindElement(By.Name("password")).SendKeys(OpenQA.Selenium.Keys.Return);//Đăng nhập tài khoản
            System.Threading.Thread.Sleep(10000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            for (int i = 0;  i < 500; i++)
            {
                driver.Navigate().GoToUrl("https://anasa.mysapogo.com/admin/products.json?page="+ i.ToString());
                var todo = driver.FindElement(By.TagName("Body")).Text;
                Root _root = JsonConvert.DeserializeObject<Root>(todo);

                if (_root.products.Count == 0)
                {
                    break;
                }

                foreach(Product pro in _root.products)
                {
                    Product _product = ProductPresenter.GetProductbyID(pro.id);
                    pro.product_id = pro.id;

                    if (_product.id > 0)
                    {                        
                        pro.id = _product.id;                        
                        ProductPresenter.UpdateProduct(pro);                        
                    }
                    else
                    {
                        pro.product_id = pro.id;
                        ProductPresenter.InsertProduct(pro);
                    }

                    foreach (Variant var in pro.variants)
                    {
                        Variant _variant = VariantPresenter.GetVariantbyID(var.id);
                        var.variant_id = var.id;

                        if (_variant.id > 0)
                        {
                            var.id = _variant.id;
                            VariantPresenter.UpdateVariant(var);                            
                        }
                        else
                        {
                            VariantPresenter.InsertVariant(var);
                        }




                    }


                    foreach (Option opt in pro.options)
                    {
                        Option _option = OptionPresenter.GetOptionbyID(opt.id);
                        opt.product_id = pro.product_id;
                        opt.option_id = opt.id;

                        string _stringvalues = "";
                        foreach (string st in opt.values)
                        {
                            _stringvalues = _stringvalues + "\"" + st + "\",";
                        }
                        opt.stringvalues = _stringvalues;

                        if (_option.id > 0)
                        {
                            opt.id = _option.id;
                            OptionPresenter.UpdateOption(opt);
                        }
                        else
                        {                                     
                            OptionPresenter.InsertOption(opt);
                        }
                    }




                }                
            }
            
                                    
        }
    }
}