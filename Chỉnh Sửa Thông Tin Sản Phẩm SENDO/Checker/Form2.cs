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

        public class Product
        {
            public int id { get; set; } // id sản phẩm chính
            public int tenant_id { get; set; } // id sản phẩm riêng
            public DateTime created_on { get; set; }
            public DateTime modified_on { get; set; }
            public string status { get; set; } // trạng thái sản phẩm
            public object brand { get; set; } // nhãn hiệu
            public string description { get; set; } // mô tả ngắn
            public object image_path { get; set; }
            public object image_name { get; set; }
            public string name { get; set; }// tên sản phẩm
            public string opt1 { get; set; }// tên thuộc tính 1
            public object opt2 { get; set; }// tên thuộc tính 2
            public object opt3 { get; set; }// tên thuộc tính 3
            public object category { get; set; } // Loại sản phẩm
            public object category_code { get; set; } // Mã Loại sản phẩm
            public string tags { get; set; } // tag
            public bool medicine { get; set; }
            public string product_type { get; set; }// Phân loại sản phẩm combo hay sản phẩm thường
            public List<Variant> variants { get; set; }// Phân loại lớn
            public List<Option> options { get; set; } // Tổng hợp tên phân loại
            public List<Image> images { get; set; } // Tổng hợp ảnh
            public object product_medicines { get; set; }


            public List<int> options_id { get; set; } //list id phân loại
            public List<int> images_id { get; set; } //list id ảnh
        }

        public class Variant
        {
            public int id { get; set; } // id phân loại            
            public int tenant_id { get; set; } // id sản phẩm riêng
            public int location_id { get; set; } // id kho hàng
            public DateTime created_on { get; set; } // thời gian tạo
            public DateTime modified_on { get; set; } // thời gian chỉnh sửa
            public object category_id { get; set; } // id Loại sản phẩm
            public object brand_id { get; set; } // id nhãn hiệu
            public int product_id { get; set; } // id sản phẩm chính
            public bool composite { get; set; } //combo sản phẩm
            public double init_price { get; set; } //định dạng giá
            public double init_stock { get; set; } //định dạng kho
            public double variant_retail_price { get; set; } // giá bán lẻ
            public double variant_whole_price { get; set; } // giá bán buôn
            public double variant_import_price { get; set; } // giá nhập
            public int image_id { get; set; } // id ảnh đại diện
            public object description { get; set; } // ghi chú
            public string name { get; set; } // tên phiên bản đầy đủ
            public string opt1 { get; set; } // tên thuộc tính
            public object opt2 { get; set; } // tên thuộc tính
            public object opt3 { get; set; } // tên thuộc tính
            public string product_name { get; set; } // tên sản phẩm
            public object product_status { get; set; } // trạng thái sản phẩm
            public string status { get; set; } // trạng thái
            public bool sellable { get; set; } // cho phép bán
            public string sku { get; set; } // SKU
            public string barcode { get; set; } // barcode
            public bool taxable { get; set; }
            public double weight_value { get; set; } // cân nặng
            public string weight_unit { get; set; } // đơn vị cân nặng
            public string unit { get; set; } // đơn vị đếm
            public bool packsize { get; set; }
            public object packsize_quantity { get; set; }
            public object packsize_root_id { get; set; }
            public object packsize_root_sku { get; set; }
            public object packsize_root_name { get; set; }
            public bool tax_included { get; set; } // thuế
            public int input_vat_id { get; set; }
            public int output_vat_id { get; set; }
            public double? input_vat_rate { get; set; }
            public double? output_vat_rate { get; set; }
            public string product_type { get; set; } // trạng thái sản phẩm
            public List<VariantPrice> variant_prices { get; set; } // các chính sách giá
            public List<Inventory> inventories { get; set; } // tồn kho
            public List<Image> images { get; set; } // ảnh
            public object composite_items { get; set; }
            public bool warranty { get; set; }
            public object warranty_term_id { get; set; }
            public object expiration_alert_time { get; set; }


        }

        public class VariantPrice
        {
            public int id { get; set; }
            public int variant_id { get; set; } // id phân loại
            public double value { get; set; } // giá
            public double included_tax_price { get; set; } // thuế
            public string name { get; set; } // tên
            public int price_list_id { get; set; } // id của chính sách giá
            public PriceList price_list { get; set; }
        }

        public class PriceList
        {
            public int id { get; set; }
            public int variant_id { get; set; } // id phân loại
            public int tenant_id { get; set; } // id sản phẩm riêng
            public DateTime created_on { get; set; }
            public DateTime modified_on { get; set; }
            public string code { get; set; } // mã chính sách giá
            public int currency_id { get; set; } // mã đơn vị tiền
            public string name { get; set; } // tên chính sách giá
            public bool is_cost { get; set; } // đã kèm chi phí
            public string currency_symbol { get; set; } // "đ"
            public string currency_iso { get; set; } // "VND"
            public string status { get; set; } // trạng thái mặc định hay mở rộng
            public bool init { get; set; }
        }
        
        public class Inventory // tồn kho
        {
            public int id { get; set; }
            public int location_id { get; set; } // id kho hàng
            public int variant_id { get; set; } // id phân loại
            public double mac { get; set; } //định dạng
            public int amount { get; set; } // đếm
            public double on_hand { get; set; } // hiện có
            public double available { get; set; } // có thể bán
            public double committed { get; set; } // đang giao dịch
            public double incoming { get; set; } // hàng đang về
            public double onway { get; set; } // đang giao
            public object min_value { get; set; } // tồn tối thiểu
            public object max_value { get; set; } // tồn tối đa
            public string bin_location { get; set; } // vị trí
            public double wait_to_pack { get; set; } // chờ đóng gói
            public object modified_on { get; set; }
        }

        public class Image // ảnh đại diện
        {
            public int id { get; set; }
            public int tenant_id { get; set; } // id sản phẩm riêng
            public double size { get; set; }
            public DateTime created_on { get; set; }
            public DateTime modified_on { get; set; }
            public string path { get; set; } // đường dẫn
            public string full_path { get; set; } // đường dẫn đầy đủ
            public string file_name { get; set; } // tên ảnh
            public bool is_default { get; set; } // ảnh đại điện phân loại
            public int position { get; set; } // thứ tự ảnh
        }

        public class Option // tên phân loại
        {
            public int id { get; set; } // id mã phân loại
            public int tenant_id { get; set; } // id sản phẩm riêng
            public string name { get; set; }// tên phân loại
            public int position { get; set; } // cấp độ phân loại
            public List<string> values { get; set; } // tổng hợp tên phân loại
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
