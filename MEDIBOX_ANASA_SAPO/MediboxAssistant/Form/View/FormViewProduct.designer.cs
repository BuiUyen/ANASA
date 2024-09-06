namespace Medibox
{
    partial class FormViewProduct
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
            this.mListViewData = new Sanita.Utility.UI.ObjectListView();
            this.olvColumn2 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn4 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn9 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn1 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn5 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn3 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn6 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn7 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.olvColumn8 = ((Sanita.Utility.UI.OLVColumn)(new Sanita.Utility.UI.OLVColumn()));
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btnImage2 = new DevComponents.DotNetBar.ButtonX();
            this.btnImage = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCountProduct = new System.Windows.Forms.TextBox();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnExport = new DevComponents.DotNetBar.ButtonItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.lblBenhAn = new DevComponents.DotNetBar.LabelX();
            this.DichVuMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.DichVuMenu = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.DataProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mListViewData)).BeginInit();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.mListViewData);
            this.panelEx1.Controls.Add(this.txtSearch);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1736, 819);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 32;
            // 
            // mListViewData
            // 
            this.mListViewData.AllColumns.Add(this.olvColumn2);
            this.mListViewData.AllColumns.Add(this.olvColumn4);
            this.mListViewData.AllColumns.Add(this.olvColumn9);
            this.mListViewData.AllColumns.Add(this.olvColumn1);
            this.mListViewData.AllColumns.Add(this.olvColumn5);
            this.mListViewData.AllColumns.Add(this.olvColumn3);
            this.mListViewData.AllColumns.Add(this.olvColumn6);
            this.mListViewData.AllColumns.Add(this.olvColumn7);
            this.mListViewData.AllColumns.Add(this.olvColumn8);
            this.mListViewData.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.mListViewData.AutoArrange = false;
            this.mListViewData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.mListViewData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mListViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn4,
            this.olvColumn9,
            this.olvColumn1,
            this.olvColumn5,
            this.olvColumn3,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8});
            this.DichVuMenuBar.SetContextMenuEx(this.mListViewData, this.DichVuMenu);
            this.mListViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mListViewData.FullRowSelect = true;
            this.mListViewData.GridLines = true;
            this.mListViewData.HideSelection = false;
            this.mListViewData.Location = new System.Drawing.Point(0, 103);
            this.mListViewData.Margin = new System.Windows.Forms.Padding(4);
            this.mListViewData.MenuLabelSortAscending = "Sắp xếp tăng dần theo \'{0}\'";
            this.mListViewData.MultiSelect = false;
            this.mListViewData.Name = "mListViewData";
            this.mListViewData.ShowGroups = false;
            this.mListViewData.Size = new System.Drawing.Size(1736, 716);
            this.mListViewData.SortGroupItemsByPrimaryColumn = false;
            this.mListViewData.TabIndex = 222;
            this.mListViewData.UnfocusedHighlightBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mListViewData.UnfocusedHighlightForegroundColor = System.Drawing.Color.White;
            this.mListViewData.UseAlternatingBackColors = true;
            this.mListViewData.UseCompatibleStateImageBehavior = false;
            this.mListViewData.UseCustomSelectionColors = true;
            this.mListViewData.UseFiltering = true;
            this.mListViewData.View = System.Windows.Forms.View.Details;
            this.mListViewData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mListViewData_MouseDoubleClick);
            this.mListViewData.Resize += new System.EventHandler(this.mListViewData_Resize);
            // 
            // olvColumn2
            // 
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "";
            this.olvColumn2.Width = 10;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "id";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.Text = "ID";
            this.olvColumn4.Width = 77;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "product_id";
            this.olvColumn9.CellPadding = null;
            this.olvColumn9.Text = "product_id";
            this.olvColumn9.Width = 126;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "name";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "name";
            this.olvColumn1.Width = 483;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "opt1";
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.Text = "opt1";
            this.olvColumn5.Width = 58;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "opt2";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.Text = "opt2";
            this.olvColumn3.Width = 59;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "opt3";
            this.olvColumn6.CellPadding = null;
            this.olvColumn6.Text = "opt3";
            this.olvColumn6.Width = 71;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "category";
            this.olvColumn7.CellPadding = null;
            this.olvColumn7.Text = "category";
            this.olvColumn7.Width = 281;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "tags";
            this.olvColumn8.CellPadding = null;
            this.olvColumn8.Text = "tags";
            this.olvColumn8.Width = 255;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtSearch.Border.BorderLeftWidth = -1;
            this.txtSearch.Border.BorderRightWidth = -1;
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.ButtonCustom.Visible = true;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.FocusHighlightEnabled = true;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 71);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(1736, 32);
            this.txtSearch.TabIndex = 221;
            this.txtSearch.WatermarkColor = System.Drawing.Color.DimGray;
            this.txtSearch.WatermarkText = "Tìm kiếm (Ctrl+F)";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btnImage2);
            this.panelEx3.Controls.Add(this.btnImage);
            this.panelEx3.Controls.Add(this.label2);
            this.panelEx3.Controls.Add(this.label1);
            this.panelEx3.Controls.Add(this.tbxCountProduct);
            this.panelEx3.Controls.Add(this.btnAdd);
            this.panelEx3.Controls.Add(this.btnRefresh);
            this.panelEx3.Controls.Add(this.buttonX1);
            this.panelEx3.Controls.Add(this.lblBenhAn);
            this.panelEx3.Controls.Add(this.DichVuMenuBar);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx3.Size = new System.Drawing.Size(1736, 71);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panelEx3.Style.BackColor2.Color = System.Drawing.SystemColors.Control;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.panelEx3.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.panelEx3.StyleMouseDown.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.panelEx3.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelEx3.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(204)))));
            this.panelEx3.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(117)))));
            this.panelEx3.StyleMouseOver.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.panelEx3.StyleMouseOver.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelEx3.TabIndex = 220;
            // 
            // btnImage2
            // 
            this.btnImage2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnImage2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnImage2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImage2.Image = global::MediboxAssistant.Properties.Resources.Edit_32x32;
            this.btnImage2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImage2.Location = new System.Drawing.Point(334, 1);
            this.btnImage2.Margin = new System.Windows.Forms.Padding(4);
            this.btnImage2.Name = "btnImage2";
            this.btnImage2.Size = new System.Drawing.Size(109, 69);
            this.btnImage2.TabIndex = 229;
            this.btnImage2.Text = "Lấy Link Ảnh";
            this.btnImage2.Click += new System.EventHandler(this.btnImage2_Click);
            // 
            // btnImage
            // 
            this.btnImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnImage.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImage.Image = global::MediboxAssistant.Properties.Resources.Edit_32x32;
            this.btnImage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImage.Location = new System.Drawing.Point(244, 1);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(90, 69);
            this.btnImage.TabIndex = 228;
            this.btnImage.Text = "Xử Lý Ảnh";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1584, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 227;
            this.label2.Text = "sản phẩm.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1373, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 226;
            this.label1.Text = "Tổng: ";
            // 
            // tbxCountProduct
            // 
            this.tbxCountProduct.Location = new System.Drawing.Point(1437, 26);
            this.tbxCountProduct.Name = "tbxCountProduct";
            this.tbxCountProduct.ReadOnly = true;
            this.tbxCountProduct.Size = new System.Drawing.Size(141, 27);
            this.tbxCountProduct.TabIndex = 225;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Image = global::MediboxAssistant.Properties.Resources.Add_32x32;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Location = new System.Drawing.Point(154, 1);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 69);
            this.btnAdd.TabIndex = 147;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Image = global::MediboxAssistant.Properties.Resources.Refresh_32__1_;
            this.btnRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefresh.Location = new System.Drawing.Point(64, 1);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 69);
            this.btnRefresh.TabIndex = 148;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.AutoExpandOnClick = true;
            this.buttonX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX1.Location = new System.Drawing.Point(1, 1);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.ShowSubItems = false;
            this.buttonX1.Size = new System.Drawing.Size(63, 69);
            this.buttonX1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.btnImport,
            this.btnExport,
            this.btnExit});
            this.buttonX1.TabIndex = 146;
            this.buttonX1.Visible = false;
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.labelItem1.ForeColor = System.Drawing.Color.Black;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.PaddingBottom = 3;
            this.labelItem1.PaddingLeft = 10;
            this.labelItem1.PaddingTop = 3;
            this.labelItem1.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.labelItem1.Text = "File";
            // 
            // btnImport
            // 
            this.btnImport.GlobalItem = false;
            this.btnImport.Name = "btnImport";
            this.btnImport.Text = "Thêm Từ File Excel";
            // 
            // btnExport
            // 
            this.btnExport.GlobalItem = false;
            this.btnExport.Name = "btnExport";
            this.btnExport.Text = "Xuất File Excel";
            // 
            // btnExit
            // 
            this.btnExit.BeginGroup = true;
            this.btnExit.GlobalItem = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "Đóng";
            // 
            // lblBenhAn
            // 
            // 
            // 
            // 
            this.lblBenhAn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBenhAn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBenhAn.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBenhAn.ForeColor = System.Drawing.Color.Maroon;
            this.lblBenhAn.Location = new System.Drawing.Point(1312, 1);
            this.lblBenhAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblBenhAn.Name = "lblBenhAn";
            this.lblBenhAn.Size = new System.Drawing.Size(423, 69);
            this.lblBenhAn.TabIndex = 9;
            this.lblBenhAn.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // DichVuMenuBar
            // 
            this.DichVuMenuBar.AntiAlias = true;
            this.DichVuMenuBar.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.DichVuMenuBar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DichVuMenuBar.IsMaximized = false;
            this.DichVuMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.DichVuMenu});
            this.DichVuMenuBar.Location = new System.Drawing.Point(986, 24);
            this.DichVuMenuBar.Margin = new System.Windows.Forms.Padding(4);
            this.DichVuMenuBar.Name = "DichVuMenuBar";
            this.DichVuMenuBar.Size = new System.Drawing.Size(105, 29);
            this.DichVuMenuBar.Stretch = true;
            this.DichVuMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DichVuMenuBar.TabIndex = 224;
            this.DichVuMenuBar.TabStop = false;
            // 
            // DichVuMenu
            // 
            this.DichVuMenu.AutoExpandOnClick = true;
            this.DichVuMenu.Name = "DichVuMenu";
            this.DichVuMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.btnXoa});
            this.DichVuMenu.Text = "Dịch Vụ";
            // 
            // labelItem2
            // 
            this.labelItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.labelItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.PaddingBottom = 1;
            this.labelItem2.PaddingLeft = 10;
            this.labelItem2.PaddingTop = 1;
            this.labelItem2.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.labelItem2.Text = "Thiết Bị";
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DataProgress
            // 
            this.DataProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            // 
            // 
            // 
            this.DataProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataProgress.Location = new System.Drawing.Point(3, 54);
            this.DataProgress.Name = "DataProgress";
            this.DataProgress.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.DataProgress.ProgressColor = System.Drawing.Color.Maroon;
            this.DataProgress.ProgressTextColor = System.Drawing.Color.Maroon;
            this.DataProgress.ProgressTextFormat = "";
            this.DataProgress.ProgressTextVisible = true;
            this.DataProgress.Size = new System.Drawing.Size(50, 50);
            this.DataProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.DataProgress.TabIndex = 223;
            this.DataProgress.Value = 100;
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.Control = this.DataProgress;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // FormViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 819);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormViewProduct";
            this.Text = "Danh Sách Sản Phẩm Omni Sapo Anasa";
            this.Load += new System.EventHandler(this.Database_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mListViewData)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btnImport;
        private DevComponents.DotNetBar.ButtonItem btnExport;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.LabelX lblBenhAn;
        private DevComponents.DotNetBar.ContextMenuBar DichVuMenuBar;
        private DevComponents.DotNetBar.ButtonItem DichVuMenu;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.Controls.CircularProgress DataProgress;
        private Sanita.Utility.UI.ObjectListView mListViewData;
        private Sanita.Utility.UI.OLVColumn olvColumn2;
        private Sanita.Utility.UI.OLVColumn olvColumn4;
        private Sanita.Utility.UI.OLVColumn olvColumn1;
        private Sanita.Utility.UI.OLVColumn olvColumn5;
        private Sanita.Utility.UI.OLVColumn olvColumn3;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private Sanita.Utility.UI.OLVColumn olvColumn6;
        private Sanita.Utility.UI.OLVColumn olvColumn7;
        private Sanita.Utility.UI.OLVColumn olvColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCountProduct;
        private Sanita.Utility.UI.OLVColumn olvColumn9;
        private DevComponents.DotNetBar.ButtonX btnImage;
        private DevComponents.DotNetBar.ButtonX btnImage2;
    }
}