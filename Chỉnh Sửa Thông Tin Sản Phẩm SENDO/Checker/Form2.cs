using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using OpenDialogWindowHandler;
using OpenQA.Selenium.Interactions;
using Newtonsoft.Json;
using System.Security.Policy;

namespace Checker
{
    public partial class Form2 : Form
    {

        public class Image
        {
            public int id { get; set; }
            public double size { get; set; }
            public DateTime created_on { get; set; }
            public DateTime modified_on { get; set; }
            public string path { get; set; }
            public string full_path { get; set; }
            public string file_name { get; set; }
            public bool is_default { get; set; }
            public int position { get; set; }
        }

        public class Inventory
        {
            public int location_id { get; set; }
            public int variant_id { get; set; }
            public double mac { get; set; }
            public int amount { get; set; }
            public double on_hand { get; set; }
            public double available { get; set; }
            public double committed { get; set; }
            public double incoming { get; set; }
            public double onway { get; set; }
            public object min_value { get; set; }
            public object max_value { get; set; }
            public string bin_location { get; set; }
            public double wait_to_pack { get; set; }
            public object modified_on { get; set; }
        }

        public class Metadata
        {
            public int total { get; set; }
            public int page { get; set; }
            public int limit { get; set; }
        }

        public class Option
        {
            public int id { get; set; }
            public string name { get; set; }
            public int position { get; set; }
            public List<string> values { get; set; }
        }

        public class PriceList
        {
            public int id { get; set; }
            public int tenant_id { get; set; }
            public DateTime created_on { get; set; }
            public DateTime modified_on { get; set; }
            public string code { get; set; }
            public int currency_id { get; set; }
            public string name { get; set; }
            public bool is_cost { get; set; }
            public string currency_symbol { get; set; }
            public string currency_iso { get; set; }
            public string status { get; set; }
            public bool init { get; set; }
        }

        public class Product
        {
            public int id { get; set; }
            public int tenant_id { get; set; }
            public DateTime created_on { get; set; }
            public DateTime modified_on { get; set; }
            public string status { get; set; }
            public object brand { get; set; }
            public string description { get; set; }
            public object image_path { get; set; }
            public object image_name { get; set; }
            public string name { get; set; }
            public string opt1 { get; set; }
            public object opt2 { get; set; }
            public object opt3 { get; set; }
            public object category { get; set; }
            public object category_code { get; set; }
            public string tags { get; set; }
            public bool medicine { get; set; }
            public string product_type { get; set; }
            public List<Variant> variants { get; set; }
            public List<Option> options { get; set; }
            public List<Image> images { get; set; }
            public object product_medicines { get; set; }
        }

        public class Root
        {
            public Metadata metadata { get; set; }
            public List<Product> products { get; set; }
        }

        public class Variant
        {
            public int id { get; set; }
            public int tenant_id { get; set; }
            public int location_id { get; set; }
            public DateTime created_on { get; set; }
            public DateTime modified_on { get; set; }
            public object category_id { get; set; }
            public object brand_id { get; set; }
            public int product_id { get; set; }
            public bool composite { get; set; }
            public double init_price { get; set; }
            public double init_stock { get; set; }
            public double variant_retail_price { get; set; }
            public double variant_whole_price { get; set; }
            public double variant_import_price { get; set; }
            public int? image_id { get; set; }
            public object description { get; set; }
            public string name { get; set; }
            public string opt1 { get; set; }
            public object opt2 { get; set; }
            public object opt3 { get; set; }
            public string product_name { get; set; }
            public object product_status { get; set; }
            public string status { get; set; }
            public bool sellable { get; set; }
            public string sku { get; set; }
            public string barcode { get; set; }
            public bool taxable { get; set; }
            public double weight_value { get; set; }
            public string weight_unit { get; set; }
            public string unit { get; set; }
            public bool packsize { get; set; }
            public object packsize_quantity { get; set; }
            public object packsize_root_id { get; set; }
            public object packsize_root_sku { get; set; }
            public object packsize_root_name { get; set; }
            public bool tax_included { get; set; }
            public int input_vat_id { get; set; }
            public int output_vat_id { get; set; }
            public double? input_vat_rate { get; set; }
            public double? output_vat_rate { get; set; }
            public string product_type { get; set; }
            public List<VariantPrice> variant_prices { get; set; }
            public List<Inventory> inventories { get; set; }
            public List<Image> images { get; set; }
            public object composite_items { get; set; }
            public bool warranty { get; set; }
            public object warranty_term_id { get; set; }
            public object expiration_alert_time { get; set; }
        }

        public class VariantPrice
        {
            public int id { get; set; }
            public double value { get; set; }
            public double included_tax_price { get; set; }
            public string name { get; set; }
            public int price_list_id { get; set; }
            public PriceList price_list { get; set; }
        }





        ChromeDriver driver;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
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
            driver.Navigate().GoToUrl("https://anasa.mysapogo.com/admin/products.json");


            var todo = driver.FindElement(By.TagName("Body")).Text;
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(todo);


            //ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            //service.HideCommandPromptWindow = true;


        }

        private void btnRun2_Click(object sender, EventArgs e)
        {
            //var model = JsonConvert.DeserializeObject<List<Product>>(tbxInput.Text);

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(tbxInput.Text);
        }
    }
}
