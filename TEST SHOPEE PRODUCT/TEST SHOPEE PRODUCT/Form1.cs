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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_SHOPEE_PRODUCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Product
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Sold { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shopUrl = "https://shopee.vn/shop/176393725"; // Thay bằng URL của shop bạn muốn lấy dữ liệu

            // Cấu hình ChromeOptions để sử dụng profile đã lưu
            var options = new ChromeOptions();
            options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

            // Khởi động Chrome với cấu hình đã thiết lập
            IWebDriver driver = new ChromeDriver(options);

            // Mở trang web của shop
            driver.Navigate().GoToUrl(shopUrl);

            // Đợi trang tải (có thể cần điều chỉnh thời gian chờ)
            System.Threading.Thread.Sleep(5000);

            // Lấy danh sách sản phẩm
            var productElements = driver.FindElements(By.CssSelector(".shop-search-result-view__item"));

            List<Product> products = new List<Product>();

            foreach (var productElement in productElements)
            {
                try
                {
                    string name = productElement.FindElement(By.CssSelector(".yQmmFK")).Text;
                    string price = productElement.FindElement(By.CssSelector(".vioxXd")).Text;
                    string sold = productElement.FindElement(By.CssSelector(".go5yPW")).Text;

                    products.Add(new Product
                    {
                        Name = name,
                        Price = price,
                        Sold = sold
                    });
                }
                catch (NoSuchElementException)
                {
                    // Nếu không tìm thấy một phần tử nào đó, bỏ qua sản phẩm này
                    continue;
                }
            }

            // Đóng trình duyệt
            driver.Quit();

            // Xuất dữ liệu ra file CSV
            string filePath = "products.csv";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name,Price,Sold");
                foreach (var product in products)
                {
                    writer.WriteLine($"{product.Name},{product.Price},{product.Sold}");
                }
            }

            Console.WriteLine($"Data has been saved to {filePath}");
        }




    }
}
