﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinh_Sua_Bai_Viet_Website
{
    public partial class Form1 : Form
    {
        DataTableCollection tableCollection;

        public class LinhKien
        {            
            public string Alias { get; set; }
            public string TenSanPham { get; set; }
            public string NoiDung { get; set; }
            public string NhaCungCap { get; set; }
            public string Loai { get; set; }
            public string Tag { get; set; }
            public string HienThi { get; set; }
            public string ThuocTinh { get; set; }
            public string GiaTriThuocTinh { get; set; }
            //
            public string ThuocTinh2 { get; set; }
            public string GiaTriThuocTinh2 { get; set; }
            //
            public string ThuocTinh3 { get; set; }
            public string GiaTriThuocTinh3 { get; set; }
            //
            public string SKU { get; set; }
            public string QuanLyKho { get; set; }
            public string SoLuong { get; set; }
            public string ChoPhepBan { get; set; }

            public string Variant { get; set; }
            public string Gia { get; set; }
            public string GiaSoSanh { get; set; }
            public string YeuCauVanChuyen { get; set; }
            public string VAT { get; set; }
            public string MaVach { get; set; }
            public string AnhDaiDien { get; set; }
            public string ChuThich { get; set; }
            public string TheTieuDe { get; set; }
            public string TheMoTa { get; set; }
            //
            public string CanNang { get; set; }
            public string DonViCan { get; set; }
            public string AnhPhienBan { get; set; }
            public string MoTaNgan { get; set; }
            public string ID { get; set; }
            public string IDTuyChon { get; set; }
            public List<string> mListAnh { get; set; } = new List<string>();


        }

        public class Tags
        {
            public int ID { get; set; }
            public string Tag { get; set; }

        }

        public List<LinhKien> mList_Goc = new List<LinhKien>();
        public List<LinhKien> mList = new List<LinhKien>();
        public List<Tags> mListTags = new List<Tags>();
        public List<Tags> mListTagsKetQua = new List<Tags>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewXuat.Hide();
            btnExcel.Hide();
            try
            {
                using (StreamReader sr = File.OpenText(@"Tags.txt"))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Tags tag = new Tags();
                        tag.ID = mListTags.Count;
                        tag.Tag = s;
                        mListTags.Add(tag);                        
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            ShowDataGirdViewTagsGoiY(mListTags);
        }

        private void btnOpenFileExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbxFile.Text = openFileDialog.FileName;
                    using (var steam = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(steam))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

                            });

                            tableCollection = result.Tables;
                            cbxSheet.Items.Clear();
                            foreach (System.Data.DataTable table in tableCollection)
                            cbxSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cbxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dt = tableCollection[cbxSheet.SelectedItem.ToString()];
                dataGridViewData.DataSource = dt;
                mList_Goc = (from DataRow dr in dt.Rows
                             select new LinhKien()
                             {
                                 Alias = dr["Đường dẫn / Alias"].ToString(),
                                 TenSanPham = dr["Tên sản phẩm"].ToString(),
                                 NoiDung = dr["Nội dung"].ToString(),
                                 NhaCungCap = dr["Nhà cung cấp"].ToString(),
                                 Loai = dr["Loại"].ToString(),
                                 Tag = dr["Tags"].ToString(),
                                 HienThi = dr["Hiển thị"].ToString(),
                                 ThuocTinh  = dr["Thuộc tính 1(Option1 Name)"].ToString(),
                                 GiaTriThuocTinh = dr["Giá trị thuộc tính 1(Option1 Value)"].ToString(),
                                 ThuocTinh2 = dr["Thuộc tính 2(Option2 Name)"].ToString(),
                                 GiaTriThuocTinh2 = dr["Giá trị thuộc tính 2(Option2 Value)"].ToString(),
                                 ThuocTinh3 = dr["Thuộc tính 3(Option3 Name)"].ToString(),
                                 GiaTriThuocTinh3 = dr["Giá trị thuộc tính 1(Option3 Value)"].ToString(),
                                 SKU = dr["Mã (SKU)"].ToString(),
                                 QuanLyKho = dr["Quản lý kho"].ToString(),
                                 SoLuong = dr["Số lượng"].ToString(),
                                 ChoPhepBan = dr["Cho phép tiếp tục mua khi hết hàng(continue/deny)"].ToString(),
                                 Variant = dr["Variant Fulfillment Service"].ToString(),
                                 Gia = dr["Giá"].ToString(),
                                 GiaSoSanh = dr["Giá so sánh"].ToString(),
                                 YeuCauVanChuyen = dr["Yêu cầu vận chuyển"].ToString(),
                                 VAT = dr["VAT"].ToString(),
                                 MaVach = dr["Mã vạch(Barcode)"].ToString(),
                                 AnhDaiDien = dr["Ảnh đại diện"].ToString(),
                                 ChuThich = dr["Chú thích ảnh"].ToString(),
                                 TheTieuDe = dr["Thẻ tiêu đề(SEO Title)"].ToString(),
                                 TheMoTa = dr["Thẻ mô tả(SEO Description)"].ToString(),
                                 CanNang = dr["Cân nặng"].ToString(),
                                 DonViCan = dr["Đơn vị cân nặng"].ToString(),
                                 AnhPhienBan = dr["Ảnh phiên bản"].ToString(),
                                 MoTaNgan = dr["Mô tả ngắn"].ToString(),
                                 ID = dr["Id sản phẩm"].ToString(),
                                 IDTuyChon = dr["Id tùy chọn"].ToString()
                             }).ToList();


                for (int x = 0; x < mList_Goc.Count; x++)
                {
                    if (mList.FirstOrDefault(v => v.ID == mList_Goc[x].ID) == null)
                    {
                        LinhKien _linhkien = new LinhKien();
                        _linhkien = mList_Goc[x];
                        if (mList_Goc[x].AnhDaiDien == "")
                        {

                        }
                        else
                        {
                            _linhkien.mListAnh.Add(mList_Goc[x].AnhDaiDien);
                        }
                        mList.Add(_linhkien);
                    }
                    else
                    {
                        int stt = mList.FindIndex(v => v.ID == mList_Goc[x].ID);
                        mList[stt].mListAnh.Add(mList_Goc[x].AnhDaiDien);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bảng Excel đang được sử dụng bởi một ứng dụng khác", "Thông Báo");
            }
        }

        private void tbxTimTags_TextChanged(object sender, EventArgs e)
        {
            string tx = tbxTimTags.Text;            
            dataGridViewTagsGoiY.Rows.Clear();
            mListTagsKetQua.Clear();

            foreach (Tags tag in mListTags)
            {
                int vi_tri = tag.Tag.ToUpper().IndexOf(tx.ToUpper());
                if (vi_tri >= 0)
                {                    
                    mListTagsKetQua.Add(tag);                    
                }
            }
            ShowDataGirdViewTagsGoiY(mListTagsKetQua);

            //Lựa chọn sản phẩm đầu tiên trong danh sách
            if (mListTagsKetQua.Count > 0)
            {
                dataGridViewTagsGoiY.Rows[0].Selected = true;
                TagLuaChon = mListTagsKetQua[0];
                lbTags.Text = TagLuaChon.Tag;
            }
            else
            {
                TagLuaChon = new Tags();
                lbTags.Text = "...";
            }    
        }

        private void dataGridViewTagsGoiY_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            try
            {
                dataGridViewTagsGoiY.CurrentRow.Selected = true;
                int ID = Convert.ToInt32(dataGridViewTagsGoiY.Rows[e.RowIndex].Cells["IDTags"].FormattedValue.ToString());
                TagLuaChon = mListTagsKetQua.First(x => x.ID == ID);
                lbTags.Text = TagLuaChon.Tag;
            }
            catch
            { }
        }

        Tags TagLuaChon = new Tags();//Tag được lựa chọn trên bảng tìm kiếm

        

        private void ShowDataGirdViewTagsGoiY(List<Tags> ListInput)
        {
            dataGridViewTagsGoiY.Rows.Clear();
            foreach (Tags tag in ListInput)
            {
                int n = dataGridViewTagsGoiY.Rows.Add();
                dataGridViewTagsGoiY.Rows[n].Cells[0].Value = tag.ID.ToString();
                dataGridViewTagsGoiY.Rows[n].Cells[1].Value = tag.Tag.ToString();                
            }
        }

        private void tbxGiaBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void tbxGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbxGiaSoSanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void tbxGiaSoSanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbxCanNang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void tbxCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        int STTLinhKien;
        int STTAnhDaiDien;
        private void btnTiep_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < mList.Count; i++)
            {
                if (mList[i].ChuThich == "")
                {
                    lbIDSanPham.Text = mList[i].ID;
                    lbIDTuyChon.Text = mList[i].IDTuyChon;
                    tbxTenSanPham.Text = mList[i].TenSanPham;
                    lbSKU.Text = mList[i].SKU;
                    tbxGiaBan.Text = mList[i].Gia;
                    tbxGiaSoSanh.Text = mList[i].GiaSoSanh;
                    tbxCanNang.Text = mList[i].CanNang;
                    STTLinhKien = i;
                    STTAnhDaiDien = 1;
                    if (mList[i].mListAnh.Count > 0)
                    {
                        var request = WebRequest.Create(mList[i].mListAnh[0]);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBox1.Image = Bitmap.FromStream(stream);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    else
                    {
                        Bitmap image = new Bitmap("chua co anh.jpg");
                        {
                            pictureBox1.Image = image;
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    lbSTTAnhDaiDien.Text = STTAnhDaiDien.ToString();
                    lbSoLuongAnh.Text = mList[i].mListAnh.Count.ToString();
                    break;
                }
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(STTAnhDaiDien > 1)
            {
                STTAnhDaiDien = STTAnhDaiDien - 1;
                var request = WebRequest.Create(mList[STTLinhKien].mListAnh[STTAnhDaiDien-1]);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                lbSTTAnhDaiDien.Text = STTAnhDaiDien.ToString();
            }
        } // nút back ảnh

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (STTAnhDaiDien < mList[STTLinhKien].mListAnh.Count)
            {
                STTAnhDaiDien = STTAnhDaiDien + 1;
                var request = WebRequest.Create(mList[STTLinhKien].mListAnh[STTAnhDaiDien-1]);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                lbSTTAnhDaiDien.Text = STTAnhDaiDien.ToString();
            }
        }// nút next ảnh

        public List<LinhKien> mListKetQua = new List<LinhKien>();

        private void btnOK_Click(object sender, EventArgs e)
        {
            mList[STTLinhKien].TenSanPham = tbxTenSanPham.Text;
            mList[STTLinhKien].Gia = tbxGiaBan.Text;
            mList[STTLinhKien].GiaSoSanh = tbxGiaSoSanh.Text;
            mList[STTLinhKien].CanNang = tbxCanNang.Text;
            mList[STTLinhKien].Tag = TagLuaChon.Tag;
            mList[STTLinhKien].ChuThich = "Đã sửa";

            if(mListKetQua.FirstOrDefault(x=>x.ID == mList[STTLinhKien].ID) == null)
            {
                mListKetQua.Add(mList[STTLinhKien]);
                MessageBox.Show("Đã thêm sản phẩm: " + mList[STTLinhKien].TenSanPham);
            }
            else
            {
                mListKetQua[mListKetQua.FindIndex(x => x.ID == mList[STTLinhKien].ID)] = mList[STTLinhKien];
                MessageBox.Show("Đã sửa sản phẩm: " + mList[STTLinhKien].TenSanPham);
            } 
            ShowDataGirdViewKetQua();            
        }

        private void ShowDataGirdViewKetQua()
        {            
            dataGridViewKetQua.Rows.Clear();
            foreach (LinhKien sp in mListKetQua)
            {
                int n = dataGridViewKetQua.Rows.Add();
                dataGridViewKetQua.Rows[n].Cells[0].Value = sp.ID;
                dataGridViewKetQua.Rows[n].Cells[1].Value = sp.IDTuyChon;
                dataGridViewKetQua.Rows[n].Cells[2].Value = sp.TenSanPham;
                dataGridViewKetQua.Rows[n].Cells[3].Value = sp.SKU;
                dataGridViewKetQua.Rows[n].Cells[4].Value = sp.Gia;
                dataGridViewKetQua.Rows[n].Cells[5].Value = sp.GiaSoSanh;
                dataGridViewKetQua.Rows[n].Cells[6].Value = sp.CanNang;
                dataGridViewKetQua.Rows[n].Cells[7].Value = sp.Tag;               
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < mList_Goc.Count; x++)
            {
                if (mList_Goc[x].IDTuyChon != "")
                {
                    LinhKien linhkien = mList.FirstOrDefault(v => v.ID == mList_Goc[x].ID);
                    mList_Goc[x].TenSanPham = linhkien.TenSanPham;
                    mList_Goc[x].Gia = linhkien.Gia;
                    mList_Goc[x].GiaSoSanh = linhkien.GiaSoSanh;
                    mList_Goc[x].Tag = linhkien.Tag;
                    mList_Goc[x].ChuThich = linhkien.ChuThich;
                }
            }

            dataGridViewXuat.Show();
            dataGridViewXuat.Rows.Clear();
            foreach (LinhKien sp in mList_Goc)
            {
                int n = dataGridViewXuat.Rows.Add();
                dataGridViewXuat.Rows[n].Cells[0].Value = sp.Alias;
                dataGridViewXuat.Rows[n].Cells[1].Value = sp.TenSanPham;
                dataGridViewXuat.Rows[n].Cells[2].Value = sp.SKU;
                dataGridViewXuat.Rows[n].Cells[3].Value = sp.Gia;
                dataGridViewXuat.Rows[n].Cells[4].Value = sp.GiaSoSanh;
                dataGridViewXuat.Rows[n].Cells[5].Value = sp.AnhDaiDien;
                dataGridViewXuat.Rows[n].Cells[6].Value = sp.CanNang;
                dataGridViewXuat.Rows[n].Cells[7].Value = sp.ID;
                dataGridViewXuat.Rows[n].Cells[8].Value = sp.IDTuyChon;
                dataGridViewXuat.Rows[n].Cells[9].Value = sp.Tag;
            }
            btnExcel.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Uyên";

            for (int i = 1; i < dataGridViewXuat.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewXuat.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridViewXuat.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewXuat.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewXuat.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Ket Qua Danh Muc San Pham";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
