namespace AttendanceManager
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnGetAttendance = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControlChamCong = new System.Windows.Forms.TabControl();
            this.tabPageNguoiDung = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.buttonGetUsers = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.comboBoxPrivilege = new System.Windows.Forms.ComboBox();
            this.comboBoxEnabled = new System.Windows.Forms.ComboBox();
            this.txtPassUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.tabControlChamCong.SuspendLayout();
            this.tabPageNguoiDung.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 120);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "button1";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(198, 31);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(195, 22);
            this.txtIPAddress.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(186, 116);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(195, 22);
            this.txtPort.TabIndex = 2;
            // 
            // btnGetAttendance
            // 
            this.btnGetAttendance.Location = new System.Drawing.Point(1163, 74);
            this.btnGetAttendance.Name = "btnGetAttendance";
            this.btnGetAttendance.Size = new System.Drawing.Size(143, 120);
            this.btnGetAttendance.TabIndex = 3;
            this.btnGetAttendance.Text = "button1";
            this.btnGetAttendance.UseVisualStyleBackColor = true;
            this.btnGetAttendance.Click += new System.EventHandler(this.btnGetAttendance_Click);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(16, 32);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 24;
            this.dataGridViewLogs.Size = new System.Drawing.Size(1055, 592);
            this.dataGridViewLogs.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // tabControlChamCong
            // 
            this.tabControlChamCong.Controls.Add(this.tabPageNguoiDung);
            this.tabControlChamCong.Controls.Add(this.tabPage2);
            this.tabControlChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlChamCong.Location = new System.Drawing.Point(12, 283);
            this.tabControlChamCong.Name = "tabControlChamCong";
            this.tabControlChamCong.SelectedIndex = 0;
            this.tabControlChamCong.Size = new System.Drawing.Size(1373, 794);
            this.tabControlChamCong.TabIndex = 8;
            // 
            // tabPageNguoiDung
            // 
            this.tabPageNguoiDung.Controls.Add(this.txtPassUser);
            this.tabPageNguoiDung.Controls.Add(this.comboBoxEnabled);
            this.tabPageNguoiDung.Controls.Add(this.comboBoxPrivilege);
            this.tabPageNguoiDung.Controls.Add(this.txtNameUser);
            this.tabPageNguoiDung.Controls.Add(this.txtUserID);
            this.tabPageNguoiDung.Controls.Add(this.btnSaveUser);
            this.tabPageNguoiDung.Controls.Add(this.buttonGetUsers);
            this.tabPageNguoiDung.Controls.Add(this.dataGridViewNguoiDung);
            this.tabPageNguoiDung.Location = new System.Drawing.Point(4, 31);
            this.tabPageNguoiDung.Name = "tabPageNguoiDung";
            this.tabPageNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNguoiDung.Size = new System.Drawing.Size(1365, 759);
            this.tabPageNguoiDung.TabIndex = 0;
            this.tabPageNguoiDung.Text = "Người dùng";
            this.tabPageNguoiDung.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewLogs);
            this.tabPage2.Controls.Add(this.btnGetAttendance);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1365, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dữ liệu chấm công";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(18, 88);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(825, 618);
            this.dataGridViewNguoiDung.TabIndex = 0;
            this.dataGridViewNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoiDung_CellClick);
            // 
            // buttonGetUsers
            // 
            this.buttonGetUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetUsers.Location = new System.Drawing.Point(18, 6);
            this.buttonGetUsers.Name = "buttonGetUsers";
            this.buttonGetUsers.Size = new System.Drawing.Size(182, 67);
            this.buttonGetUsers.TabIndex = 1;
            this.buttonGetUsers.Text = "Tải dữ liệu người dùng";
            this.buttonGetUsers.UseVisualStyleBackColor = true;
            this.buttonGetUsers.Click += new System.EventHandler(this.buttonGetUsers_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.Location = new System.Drawing.Point(1138, 476);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(182, 44);
            this.btnSaveUser.TabIndex = 2;
            this.btnSaveUser.Text = "Lưu người dùng";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(1232, 129);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 28);
            this.txtUserID.TabIndex = 3;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(1116, 163);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(231, 28);
            this.txtNameUser.TabIndex = 4;
            // 
            // comboBoxPrivilege
            // 
            this.comboBoxPrivilege.FormattingEnabled = true;
            this.comboBoxPrivilege.Location = new System.Drawing.Point(1153, 257);
            this.comboBoxPrivilege.Name = "comboBoxPrivilege";
            this.comboBoxPrivilege.Size = new System.Drawing.Size(121, 30);
            this.comboBoxPrivilege.TabIndex = 5;
            // 
            // comboBoxEnabled
            // 
            this.comboBoxEnabled.FormattingEnabled = true;
            this.comboBoxEnabled.Location = new System.Drawing.Point(1153, 314);
            this.comboBoxEnabled.Name = "comboBoxEnabled";
            this.comboBoxEnabled.Size = new System.Drawing.Size(121, 30);
            this.comboBoxEnabled.TabIndex = 6;
            // 
            // txtPassUser
            // 
            this.txtPassUser.Location = new System.Drawing.Point(1116, 209);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.Size = new System.Drawing.Size(231, 28);
            this.txtPassUser.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1345, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 157);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 1134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlChamCong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.tabControlChamCong.ResumeLayout(false);
            this.tabPageNguoiDung.ResumeLayout(false);
            this.tabPageNguoiDung.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnGetAttendance;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControlChamCong;
        private System.Windows.Forms.TabPage tabPageNguoiDung;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonGetUsers;
        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.ComboBox comboBoxEnabled;
        private System.Windows.Forms.ComboBox comboBoxPrivilege;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassUser;
        private System.Windows.Forms.Button button1;
    }
}

