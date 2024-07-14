using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace Checker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class Xchina
        {
            public string IDPage { get; set; }
            public string Name { get; set; }
            public string Actor { get; set; }
            public string Albums { get; set; }
            public string stt_Albums { get; set; }
            public string Link { get; set; }
            public string LinkAnh { get; set; }
            public List<string> ListLinkAnh { get; set; }            
        }

        public class Image
        {
            public string IDPage { get; set; }
            public string Link { get; set; }
            public string Alt { get; set; }
        }
       

        public List<Xchina> mListXchina = new List<Xchina>();

        public List<Image> mListKetQua = new List<Image>();
 

        private void button1_Click(object sender, EventArgs e)
        {            
            string Albums;
            Albums = txbMenu.Text;

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //options.AddArgument("--window-position=-32000,-32000"); //an chorme

            IWebDriver driver = new ChromeDriver(driverService, options);
            driver.Navigate().GoToUrl("https://www.google.com/");
            System.Threading.Thread.Sleep(300);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            mListXchina = new List<Xchina>();
            int s = 1;
            do
            {                
                //_checker.ListAnh = new List<string>(12);

                string linkdh = Albums + "/" + s.ToString() + ".html";
                try
                {
                    driver.Navigate().GoToUrl(linkdh);
                }
                catch (Exception ex)
                {
                    Actions actions = new Actions(driver);
                    actions.SendKeys(OpenQA.Selenium.Keys.Escape);
                }
                var linkElement = driver.FindElements(By.XPath("//a[@target='_blank']"));

                // Lấy thuộc tính href từ phần tử
                int dem = 0;
                foreach(var pt in linkElement )
                {
                    string href = pt.GetAttribute("href");
                    if (href.Contains(@"photo/id"))
                    {
                        string[] arrListStr = href.Split('/');

                        Xchina _xchina = new Xchina();
                        _xchina.IDPage = arrListStr[4].Substring(3,13);
                        _xchina.Link = href;
                        _xchina.stt_Albums = s.ToString();
                        _xchina.Albums = linkdh;
                        mListXchina.Add(_xchina);
                        dem++;
                    }
                }
                if(dem == 0)
                {
                    break;
                }
                s++;                
            }
            while (s > 0);
            ShowKetQua();
        }

        public void ShowKetQua()
        {
            dataGridViewLink.Rows.Clear();
            foreach (Xchina ch in mListXchina)
            {
                int n = dataGridViewLink.Rows.Add();
                dataGridViewLink.Rows[n].Cells[0].Value = ch.IDPage;
                dataGridViewLink.Rows[n].Cells[1].Value = ch.Albums;
                dataGridViewLink.Rows[n].Cells[2].Value = ch.stt_Albums;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Albums;
            Albums = txbMenu.Text;

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //options.AddArgument("--window-position=-32000,-32000"); //an chorme

            IWebDriver driver = new ChromeDriver(driverService, options);
            driver.Navigate().GoToUrl("https://www.google.com/");
            System.Threading.Thread.Sleep(300);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            mListXchina = new List<Xchina>();
            int s = 1;
            do
            {
                //_checker.ListAnh = new List<string>(12);

                string linkdh = Albums;
                try
                {
                    driver.Navigate().GoToUrl(linkdh);
                }
                catch (Exception ex)
                {
                    Actions actions = new Actions(driver);
                    actions.SendKeys(OpenQA.Selenium.Keys.Escape);
                }

                Xchina mXchina = new Xchina();
                mXchina.Name = driver.FindElement(By.ClassName("fa-address-card-o")).Text;

                mXchina.Name = driver.FindElement(By.ClassName("actorsOrModels")).Text;

                var linkElement = driver.FindElements(By.XPath("//a[@target='_blank']"));

                // Lấy thuộc tính href từ phần tử
                foreach (var pt in linkElement)
                {
                    string href = pt.GetAttribute("href");
                    if (href.Contains(@"photo/id"))
                    {
                        string[] arrListStr = href.Split('/');

                        Xchina _xchina = new Xchina();
                        _xchina.IDPage = arrListStr[4].Substring(0, 16);
                        _xchina.Link = href;
                        _xchina.stt_Albums = s.ToString();
                        _xchina.Albums = linkdh;
                        mListXchina.Add(_xchina);
                    }
                }
                s++;
            }
            while (s > 0);


            ShowKetQua();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Trang_tính1"];
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            worksheet.Name = "Uyên";

            for (int i = 1; i < dataGridViewLink.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewLink.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridViewLink.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewLink.Columns.Count; j++)
                {
                    if (dataGridViewLink.Rows[i].Cells[j].Value == null)
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                    else
                        worksheet.Cells[i + 2, j + 1] = dataGridViewLink.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Ket Qua";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
