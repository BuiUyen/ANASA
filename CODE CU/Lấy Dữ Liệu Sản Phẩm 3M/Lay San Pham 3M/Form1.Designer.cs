﻿namespace Lay_San_Pham_3M
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLaySanPham = new System.Windows.Forms.Button();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.LinkSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSoTrang = new System.Windows.Forms.TextBox();
            this.btnXuat1 = new System.Windows.Forms.Button();
            this.dataGridViewDaTa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbxSheet = new System.Windows.Forms.ComboBox();
            this.btnXuLi = new System.Windows.Forms.Button();
            this.dataGridViewKetQua = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewKetQua2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaySanPham
            // 
            this.btnLaySanPham.Location = new System.Drawing.Point(18, 18);
            this.btnLaySanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaySanPham.Name = "btnLaySanPham";
            this.btnLaySanPham.Size = new System.Drawing.Size(141, 35);
            this.btnLaySanPham.TabIndex = 0;
            this.btnLaySanPham.Text = "Truy Cập 3M";
            this.btnLaySanPham.UseVisualStyleBackColor = true;
            this.btnLaySanPham.Click += new System.EventHandler(this.btnLaySanPham_Click);
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LinkSanPham,
            this.TenSanPham,
            this.Gia});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(18, 63);
            this.dataGridViewSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 62;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(651, 611);
            this.dataGridViewSanPham.TabIndex = 1;
            // 
            // LinkSanPham
            // 
            this.LinkSanPham.HeaderText = "Link Sản Phẩm";
            this.LinkSanPham.MinimumWidth = 8;
            this.LinkSanPham.Name = "LinkSanPham";
            this.LinkSanPham.Width = 150;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.MinimumWidth = 8;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 150;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            this.Gia.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Trang Sản Phẩm:";
            // 
            // txbSoTrang
            // 
            this.txbSoTrang.Location = new System.Drawing.Point(362, 22);
            this.txbSoTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSoTrang.Name = "txbSoTrang";
            this.txbSoTrang.Size = new System.Drawing.Size(66, 26);
            this.txbSoTrang.TabIndex = 3;
            this.txbSoTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSoTrang_KeyPress);
            // 
            // btnXuat1
            // 
            this.btnXuat1.Location = new System.Drawing.Point(18, 689);
            this.btnXuat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuat1.Name = "btnXuat1";
            this.btnXuat1.Size = new System.Drawing.Size(112, 35);
            this.btnXuat1.TabIndex = 4;
            this.btnXuat1.Text = "Xuất Excel";
            this.btnXuat1.UseVisualStyleBackColor = true;
            this.btnXuat1.Click += new System.EventHandler(this.btnXuat1_Click);
            // 
            // dataGridViewDaTa
            // 
            this.dataGridViewDaTa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaTa.Location = new System.Drawing.Point(678, 63);
            this.dataGridViewDaTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaTa.Name = "dataGridViewDaTa";
            this.dataGridViewDaTa.RowHeadersWidth = 62;
            this.dataGridViewDaTa.Size = new System.Drawing.Size(651, 231);
            this.dataGridViewDaTa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "File:";
            // 
            // txbFile
            // 
            this.txbFile.Location = new System.Drawing.Point(722, 22);
            this.txbFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFile.Name = "txbFile";
            this.txbFile.Size = new System.Drawing.Size(403, 26);
            this.txbFile.TabIndex = 7;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(1143, 21);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(39, 31);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbxSheet
            // 
            this.cbxSheet.FormattingEnabled = true;
            this.cbxSheet.Location = new System.Drawing.Point(1190, 22);
            this.cbxSheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSheet.Name = "cbxSheet";
            this.cbxSheet.Size = new System.Drawing.Size(144, 28);
            this.cbxSheet.TabIndex = 9;
            this.cbxSheet.SelectedIndexChanged += new System.EventHandler(this.cbxSheet_SelectedIndexChanged);
            // 
            // btnXuLi
            // 
            this.btnXuLi.Location = new System.Drawing.Point(906, 303);
            this.btnXuLi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuLi.Name = "btnXuLi";
            this.btnXuLi.Size = new System.Drawing.Size(202, 42);
            this.btnXuLi.TabIndex = 10;
            this.btnXuLi.Text = "Lấy Ảnh Và Thông Số";
            this.btnXuLi.UseVisualStyleBackColor = true;
            this.btnXuLi.Click += new System.EventHandler(this.btnXuLi_Click);
            // 
            // dataGridViewKetQua
            // 
            this.dataGridViewKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridViewKetQua.Location = new System.Drawing.Point(678, 354);
            this.dataGridViewKetQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKetQua.Name = "dataGridViewKetQua";
            this.dataGridViewKetQua.RowHeadersWidth = 62;
            this.dataGridViewKetQua.Size = new System.Drawing.Size(651, 320);
            this.dataGridViewKetQua.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Link Sản Phẩm";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thông Số Kĩ Thuật";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Link Ảnh 1";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Link Ảnh 2";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Link Ảnh 3";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Link Ảnh 4";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Link Ảnh 5";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Link Ảnh 6";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Cân Nặng";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Phân Loại";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 1105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 684);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1254, 1097);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "Xuất file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewKetQua2
            // 
            this.dataGridViewKetQua2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKetQua2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridViewKetQua2.Location = new System.Drawing.Point(18, 763);
            this.dataGridViewKetQua2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKetQua2.Name = "dataGridViewKetQua2";
            this.dataGridViewKetQua2.RowHeadersWidth = 62;
            this.dataGridViewKetQua2.Size = new System.Drawing.Size(1316, 320);
            this.dataGridViewKetQua2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Link Sản Phẩm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "SKU";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.Width = 150;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Phân loại";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Giá bán";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Giá cũ";
            this.Column16.MinimumWidth = 8;
            this.Column16.Name = "Column16";
            this.Column16.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 1175);
            this.Controls.Add(this.dataGridViewKetQua2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewKetQua);
            this.Controls.Add(this.btnXuLi);
            this.Controls.Add(this.cbxSheet);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txbFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDaTa);
            this.Controls.Add(this.btnXuat1);
            this.Controls.Add(this.txbSoTrang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.btnLaySanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Uyên Đẹp Zai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaySanPham;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSoTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button btnXuat1;
        private System.Windows.Forms.DataGridView dataGridViewDaTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cbxSheet;
        private System.Windows.Forms.Button btnXuLi;
        private System.Windows.Forms.DataGridView dataGridViewKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewKetQua2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
    }
}

