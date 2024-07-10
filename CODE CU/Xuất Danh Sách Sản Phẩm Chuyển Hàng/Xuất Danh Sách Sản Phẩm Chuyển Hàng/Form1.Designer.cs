namespace Xuất_Danh_Sách_Sản_Phẩm_Chuyển_Hàng
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
            this.components = new System.ComponentModel.Container();
            this.cbxSheet = new System.Windows.Forms.ComboBox();
            this.btnOpenFileExcel = new System.Windows.Forms.Button();
            this.tbxFile = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.btnRUN = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSheet
            // 
            this.cbxSheet.FormattingEnabled = true;
            this.cbxSheet.Location = new System.Drawing.Point(719, 17);
            this.cbxSheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSheet.Name = "cbxSheet";
            this.cbxSheet.Size = new System.Drawing.Size(160, 24);
            this.cbxSheet.TabIndex = 5;
            this.cbxSheet.SelectedIndexChanged += new System.EventHandler(this.cbxSheet_SelectedIndexChanged);
            // 
            // btnOpenFileExcel
            // 
            this.btnOpenFileExcel.Location = new System.Drawing.Point(611, 17);
            this.btnOpenFileExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFileExcel.Name = "btnOpenFileExcel";
            this.btnOpenFileExcel.Size = new System.Drawing.Size(100, 25);
            this.btnOpenFileExcel.TabIndex = 4;
            this.btnOpenFileExcel.Text = "Open";
            this.btnOpenFileExcel.UseVisualStyleBackColor = true;
            this.btnOpenFileExcel.Click += new System.EventHandler(this.btnOpenFileExcel_Click);
            // 
            // tbxFile
            // 
            this.tbxFile.Location = new System.Drawing.Point(16, 15);
            this.tbxFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxFile.Name = "tbxFile";
            this.tbxFile.Size = new System.Drawing.Size(585, 22);
            this.tbxFile.TabIndex = 3;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(16, 50);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.Size = new System.Drawing.Size(1551, 302);
            this.dataGridViewData.TabIndex = 6;
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewInput.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewInput.Location = new System.Drawing.Point(1609, 50);
            this.dataGridViewInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowHeadersWidth = 51;
            this.dataGridViewInput.Size = new System.Drawing.Size(327, 681);
            this.dataGridViewInput.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dánToolStripMenuItem,
            this.xóaTấtCảToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 52);
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.dánToolStripMenuItem.Text = "Dán";
            this.dánToolStripMenuItem.Click += new System.EventHandler(this.dánToolStripMenuItem_Click);
            // 
            // xóaTấtCảToolStripMenuItem
            // 
            this.xóaTấtCảToolStripMenuItem.Name = "xóaTấtCảToolStripMenuItem";
            this.xóaTấtCảToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xóaTấtCảToolStripMenuItem.Text = "Xóa Tất Cả";
            this.xóaTấtCảToolStripMenuItem.Click += new System.EventHandler(this.xóaTấtCảToolStripMenuItem_Click);
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewOutput.Location = new System.Drawing.Point(16, 380);
            this.dataGridViewOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.RowHeadersWidth = 51;
            this.dataGridViewOutput.Size = new System.Drawing.Size(1232, 351);
            this.dataGridViewOutput.TabIndex = 9;
            // 
            // btnRUN
            // 
            this.btnRUN.Location = new System.Drawing.Point(1357, 481);
            this.btnRUN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(172, 98);
            this.btnRUN.TabIndex = 10;
            this.btnRUN.Text = "Chạy";
            this.btnRUN.UseVisualStyleBackColor = true;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SKU";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "STT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên phiên bản phẩm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 500;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SKU";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vị trí kho";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1991, 746);
            this.Controls.Add(this.btnRUN);
            this.Controls.Add(this.dataGridViewOutput);
            this.Controls.Add(this.dataGridViewInput);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.cbxSheet);
            this.Controls.Add(this.btnOpenFileExcel);
            this.Controls.Add(this.tbxFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tạo file chuyển hàng - Uyên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSheet;
        private System.Windows.Forms.Button btnOpenFileExcel;
        private System.Windows.Forms.TextBox tbxFile;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTấtCảToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.Button btnRUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

