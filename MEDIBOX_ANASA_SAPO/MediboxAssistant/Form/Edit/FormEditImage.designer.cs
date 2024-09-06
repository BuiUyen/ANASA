namespace Medibox
{
    partial class FormEditImage
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridViewKetQua = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTuyChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSoSanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhDaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxInputSKU = new System.Windows.Forms.TextBox();
            this.labelTEXT = new System.Windows.Forms.Label();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.dataGridViewKetQua);
            this.panelEx1.Controls.Add(this.tbxInputSKU);
            this.panelEx1.Controls.Add(this.labelTEXT);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1419, 817);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 32;
            // 
            // dataGridViewKetQua
            // 
            this.dataGridViewKetQua.AllowUserToOrderColumns = true;
            this.dataGridViewKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDTuyChon,
            this.TenSanPham,
            this.SKU,
            this.GiaBan,
            this.GiaSoSanh,
            this.CanNang,
            this.AnhDaiDien,
            this.Column35,
            this.Column36,
            this.Column1});
            this.dataGridViewKetQua.Location = new System.Drawing.Point(26, 103);
            this.dataGridViewKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKetQua.Name = "dataGridViewKetQua";
            this.dataGridViewKetQua.RowHeadersWidth = 51;
            this.dataGridViewKetQua.Size = new System.Drawing.Size(1252, 658);
            this.dataGridViewKetQua.TabIndex = 120;
            // 
            // ID
            // 
            this.ID.FillWeight = 53.47593F;
            this.ID.HeaderText = "SKU";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // IDTuyChon
            // 
            this.IDTuyChon.FillWeight = 50.87589F;
            this.IDTuyChon.HeaderText = "Ảnh 1";
            this.IDTuyChon.MinimumWidth = 6;
            this.IDTuyChon.Name = "IDTuyChon";
            // 
            // TenSanPham
            // 
            this.TenSanPham.FillWeight = 51.10219F;
            this.TenSanPham.HeaderText = "Ảnh 2";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            // 
            // SKU
            // 
            this.SKU.FillWeight = 52.70367F;
            this.SKU.HeaderText = "Ảnh 3";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            // 
            // GiaBan
            // 
            this.GiaBan.FillWeight = 57.26415F;
            this.GiaBan.HeaderText = "Ảnh 4";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            // 
            // GiaSoSanh
            // 
            this.GiaSoSanh.FillWeight = 66.8898F;
            this.GiaSoSanh.HeaderText = "Ảnh 5";
            this.GiaSoSanh.MinimumWidth = 6;
            this.GiaSoSanh.Name = "GiaSoSanh";
            // 
            // CanNang
            // 
            this.CanNang.FillWeight = 85.26781F;
            this.CanNang.HeaderText = "Ảnh 6";
            this.CanNang.MinimumWidth = 6;
            this.CanNang.Name = "CanNang";
            // 
            // AnhDaiDien
            // 
            this.AnhDaiDien.FillWeight = 118.8482F;
            this.AnhDaiDien.HeaderText = "Ảnh 7";
            this.AnhDaiDien.MinimumWidth = 6;
            this.AnhDaiDien.Name = "AnhDaiDien";
            // 
            // Column35
            // 
            this.Column35.FillWeight = 178.8262F;
            this.Column35.HeaderText = "Ảnh 8";
            this.Column35.MinimumWidth = 8;
            this.Column35.Name = "Column35";
            // 
            // Column36
            // 
            this.Column36.FillWeight = 284.7459F;
            this.Column36.HeaderText = "Ảnh 9";
            this.Column36.MinimumWidth = 8;
            this.Column36.Name = "Column36";
            // 
            // tbxInputSKU
            // 
            this.tbxInputSKU.Location = new System.Drawing.Point(1285, 11);
            this.tbxInputSKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxInputSKU.Multiline = true;
            this.tbxInputSKU.Name = "tbxInputSKU";
            this.tbxInputSKU.Size = new System.Drawing.Size(122, 752);
            this.tbxInputSKU.TabIndex = 116;
            // 
            // labelTEXT
            // 
            this.labelTEXT.AutoSize = true;
            this.labelTEXT.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTEXT.Location = new System.Drawing.Point(43, 32);
            this.labelTEXT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTEXT.Name = "labelTEXT";
            this.labelTEXT.Size = new System.Drawing.Size(443, 41);
            this.labelTEXT.TabIndex = 105;
            this.labelTEXT.Text = "Chạy Tool Lấy Dữ Liệu Sapo";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnRun);
            this.panelEx2.Controls.Add(this.btnSave);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 769);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx2.Size = new System.Drawing.Size(1419, 48);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 52;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(179, 40);
            this.btnRun.TabIndex = 101;
            this.btnRun.Text = "Xử lý lấy link ảnh";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Image = global::MediboxAssistant.Properties.Resources.Save_32x32;
            this.btnSave.Location = new System.Drawing.Point(1270, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(148, 46);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ảnh 10";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // FormEditImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 817);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEditImage";
            this.Text = "Cập Nhật Ảnh Sản Phẩm";
            this.Load += new System.EventHandler(this.Database_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Label labelTEXT;
        private System.Windows.Forms.TextBox tbxInputSKU;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dataGridViewKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTuyChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSoSanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}