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

        private AutocompleteMenu mAutoMennu_User = new AutocompleteMenu();
        private AutocompleteMenu mAutoMennu_Home = new AutocompleteMenu();
        private AutocompleteMenu mAutoMennu_Room = new AutocompleteMenu();

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

            //mDevice = _mDevice ?? new Device();
            //mListDevice = _mListDevice;

            //txtDeviceCode.Text = mDevice.DeviceCode;
            //txtDeviceName.Text = mDevice.DeviceName;
            //txtTenRutGon.Text = mDevice.DeviceName_Short;

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
            mAutoMennu_User.SetAutocompleteItems(MyVar.mListUser.Select(p => new AutoData(p.UserName, p.UserID.ToString())).ToList());
            mAutoMennu_User.ComboboxMode = true;
            mAutoMennu_User.MaximumSize = new System.Drawing.Size(txtUser.Width - 4, 300);
            mAutoMennu_User.SetAutocompleteMenu(txtUser);
            txtUser.KeyDown += Control_KeyDown;

            //mAutoMennu_Home.SetAutocompleteItems(MyVar.mListHome.Select(p => new AutoData(p.HomeName, p.HomeID.ToString())).ToList());
            mAutoMennu_Home.ComboboxMode = true;
            mAutoMennu_Home.MaximumSize = new System.Drawing.Size(txtHome.Width - 4, 300);
            mAutoMennu_Home.SetAutocompleteMenu(txtHome);
            txtHome.KeyDown += Control_KeyDown;

            //mAutoMennu_Room.SetAutocompleteItems(MyVar.mListRoom.Select(p => new AutoData(p.RoomName, p.RoomID.ToString())).ToList());
            mAutoMennu_Room.ComboboxMode = true;
            mAutoMennu_Room.MaximumSize = new System.Drawing.Size(txtRoom.Width - 4, 300);
            mAutoMennu_Room.SetAutocompleteMenu(txtRoom);
            txtRoom.KeyDown += Control_KeyDown;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate
            if (String.IsNullOrEmpty(txtDeviceCode.Text.Trim()))
            {
                SanitaMessageBox.Show("Chưa nhập code !", "Thông Báo".Translate());
                txtDeviceCode.Focus();
                return;
            }

            //mDevice.DeviceCode = txtDeviceCode.Text;
            //mDevice.DeviceName = txtDeviceName.Text;
            //mDevice.DeviceName_Short = txtTenRutGon.Text;
            ////mDevice.HomeID = Home.GetID(txtHome.Text.Trim());
            ////mDevice.RoomID = Room.GetID(txtRoom.Text.Trim());
            //mDevice.UserID = User.GetID(txtUser.Text.Trim());

            bwAsync_Start(ProcessingType.SaveData);
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 0x0D)
            {
                SendKeys.SendWait("{TAB}");
            }
        }

        private void txtHome_ButtonCustomClick(object sender, EventArgs e)
        {
            mAutoMennu_Home.Show(txtHome, true, true);
        }

        private void txtRoom_ButtonCustomClick(object sender, EventArgs e)
        {
            mAutoMennu_Room.Show(txtRoom, true, true);
        }

        private void txtUser_ButtonCustomClick(object sender, EventArgs e)
        {
            mAutoMennu_User.Show(txtUser, true, true);
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

            for (int i = 0;  i < 163; i++)
            {
                driver.Navigate().GoToUrl("https://anasa.mysapogo.com/admin/products.json?page="+ i.ToString());
                var todo = driver.FindElement(By.TagName("Body")).Text;
                Root _root = JsonConvert.DeserializeObject<Root>(todo);

                foreach(Product pro in _root.products)
                {
                    if (pro.id > 0)
                    {
                        pro.product_id = pro.id;
                        ProductPresenter.InsertProduct(pro);
                    }
                    else
                    {
                       
                    }                    
                }
            }
            
                                    
        }
    }
}