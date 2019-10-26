namespace CES_TMS.subWindows.priceManager
{
    partial class CostPriceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSaveASAgree = new DevComponents.DotNetBar.ButtonItem();
            this.cboxAllTime = new System.Windows.Forms.CheckBox();
            this.comboBoxExState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.dateTimeInputEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInputStart = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxProduct = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtServiceChannel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnServiceChannel = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInputValidate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnSaveASPublish = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewXMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PriceName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.HostChannelName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.HostProductName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.GoodsType = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.StatusName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.EffectBegin = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.EffectEnd = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.CreateTime = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.CreateOpName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonItem();
            this.btnDel = new DevComponents.DotNetBar.ButtonItem();
            this.btnDetail = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSend = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaveASCost = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaveASSale = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputValidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveASAgree
            // 
            this.btnSaveASAgree.Name = "btnSaveASAgree";
            this.btnSaveASAgree.Text = "另存为协议价";
            this.btnSaveASAgree.Visible = false;
            this.btnSaveASAgree.Click += new System.EventHandler(this.btnSaveASAgree_Click);
            // 
            // cboxAllTime
            // 
            this.cboxAllTime.AutoSize = true;
            this.cboxAllTime.Location = new System.Drawing.Point(905, 65);
            this.cboxAllTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxAllTime.Name = "cboxAllTime";
            this.cboxAllTime.Size = new System.Drawing.Size(111, 20);
            this.cboxAllTime.TabIndex = 28;
            this.cboxAllTime.Text = "显示所有方案";
            this.cboxAllTime.UseVisualStyleBackColor = true;
            // 
            // comboBoxExState
            // 
            this.comboBoxExState.DisplayMember = "Text";
            this.comboBoxExState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxExState.FormattingEnabled = true;
            this.comboBoxExState.ItemHeight = 21;
            this.comboBoxExState.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem1,
            this.comboItem2});
            this.comboBoxExState.Location = new System.Drawing.Point(752, 14);
            this.comboBoxExState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxExState.Name = "comboBoxExState";
            this.comboBoxExState.Size = new System.Drawing.Size(198, 27);
            this.comboBoxExState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxExState.TabIndex = 27;
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "全部";
            this.comboItem4.Value = "0";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "草稿";
            this.comboItem1.Value = "1";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "发布";
            this.comboItem2.Value = "2";
            // 
            // dateTimeInputEnd
            // 
            // 
            // 
            // 
            this.dateTimeInputEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputEnd.ButtonDropDown.Visible = true;
            this.dateTimeInputEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeInputEnd.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputEnd.IsPopupCalendarOpen = false;
            this.dateTimeInputEnd.Location = new System.Drawing.Point(681, 61);
            this.dateTimeInputEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeInputEnd.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.dateTimeInputEnd.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.DaySize = new System.Drawing.Size(24, 25);
            this.dateTimeInputEnd.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dateTimeInputEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.Name = "dateTimeInputEnd";
            this.dateTimeInputEnd.Size = new System.Drawing.Size(208, 26);
            this.dateTimeInputEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputEnd.TabIndex = 26;
            // 
            // dateTimeInputStart
            // 
            // 
            // 
            // 
            this.dateTimeInputStart.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputStart.ButtonDropDown.Visible = true;
            this.dateTimeInputStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimeInputStart.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputStart.IsPopupCalendarOpen = false;
            this.dateTimeInputStart.Location = new System.Drawing.Point(434, 61);
            this.dateTimeInputStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeInputStart.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.dateTimeInputStart.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.DaySize = new System.Drawing.Size(24, 25);
            this.dateTimeInputStart.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dateTimeInputStart.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.Name = "dateTimeInputStart";
            this.dateTimeInputStart.Size = new System.Drawing.Size(208, 26);
            this.dateTimeInputStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputStart.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxAllTime);
            this.panel1.Controls.Add(this.comboBoxExState);
            this.panel1.Controls.Add(this.dateTimeInputEnd);
            this.panel1.Controls.Add(this.dateTimeInputStart);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.comboBoxProduct);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.txtServiceChannel);
            this.panel1.Controls.Add(this.btnServiceChannel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.dateTimeInputValidate);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 101);
            this.panel1.TabIndex = 21;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX7.Location = new System.Drawing.Point(653, 60);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(20, 31);
            this.labelX7.TabIndex = 24;
            this.labelX7.Text = "-";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX6.Location = new System.Drawing.Point(335, 60);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(88, 31);
            this.labelX6.TabIndex = 22;
            this.labelX6.Text = "创建时间";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX5.Location = new System.Drawing.Point(335, 15);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(88, 31);
            this.labelX5.TabIndex = 22;
            this.labelX5.Text = "销售产品";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DisplayMember = "Text";
            this.comboBoxProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.ItemHeight = 21;
            this.comboBoxProduct.Location = new System.Drawing.Point(434, 12);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(208, 27);
            this.comboBoxProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxProduct.TabIndex = 23;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX3.Location = new System.Drawing.Point(6, 16);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(84, 31);
            this.labelX3.TabIndex = 19;
            this.labelX3.Text = "服务渠道";
            // 
            // txtServiceChannel
            // 
            // 
            // 
            // 
            this.txtServiceChannel.Border.Class = "TextBoxBorder";
            this.txtServiceChannel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtServiceChannel.Location = new System.Drawing.Point(100, 16);
            this.txtServiceChannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceChannel.Name = "txtServiceChannel";
            this.txtServiceChannel.PreventEnterBeep = true;
            this.txtServiceChannel.ReadOnly = true;
            this.txtServiceChannel.Size = new System.Drawing.Size(192, 26);
            this.txtServiceChannel.TabIndex = 20;
            // 
            // btnServiceChannel
            // 
            this.btnServiceChannel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnServiceChannel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnServiceChannel.Location = new System.Drawing.Point(297, 14);
            this.btnServiceChannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceChannel.Name = "btnServiceChannel";
            this.btnServiceChannel.Size = new System.Drawing.Size(28, 28);
            this.btnServiceChannel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnServiceChannel.TabIndex = 21;
            this.btnServiceChannel.Click += new System.EventHandler(this.btnServiceChannel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(1057, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 33);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "查询";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX2.Location = new System.Drawing.Point(664, 15);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(77, 31);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "方案状态";
            // 
            // dateTimeInputValidate
            // 
            // 
            // 
            // 
            this.dateTimeInputValidate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputValidate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputValidate.ButtonDropDown.Visible = true;
            this.dateTimeInputValidate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeInputValidate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputValidate.IsPopupCalendarOpen = false;
            this.dateTimeInputValidate.Location = new System.Drawing.Point(100, 60);
            this.dateTimeInputValidate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeInputValidate.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.dateTimeInputValidate.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputValidate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dateTimeInputValidate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputValidate.MonthCalendar.DisplayMonth = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeInputValidate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputValidate.Name = "dateTimeInputValidate";
            this.dateTimeInputValidate.Size = new System.Drawing.Size(225, 26);
            this.dateTimeInputValidate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputValidate.TabIndex = 15;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX1.Location = new System.Drawing.Point(8, 60);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(78, 31);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "有效时间";
            // 
            // btnSaveASPublish
            // 
            this.btnSaveASPublish.Name = "btnSaveASPublish";
            this.btnSaveASPublish.Text = "另存为公布价";
            this.btnSaveASPublish.Click += new System.EventHandler(this.btnSaveASPublish_Click);
            // 
            // dataGridViewXMain
            // 
            this.dataGridViewXMain.AllowUserToAddRows = false;
            this.dataGridViewXMain.AllowUserToDeleteRows = false;
            this.dataGridViewXMain.AllowUserToResizeRows = false;
            this.dataGridViewXMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewXMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceName,
            this.HostChannelName,
            this.HostProductName,
            this.GoodsType,
            this.StatusName,
            this.EffectBegin,
            this.EffectEnd,
            this.CreateTime,
            this.CreateOpName,
            this.ID});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXMain.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewXMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXMain.EnableHeadersVisualStyles = false;
            this.dataGridViewXMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewXMain.Location = new System.Drawing.Point(0, 132);
            this.dataGridViewXMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewXMain.Name = "dataGridViewXMain";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewXMain.RowHeadersWidth = 65;
            this.dataGridViewXMain.RowTemplate.Height = 23;
            this.dataGridViewXMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXMain.Size = new System.Drawing.Size(1206, 468);
            this.dataGridViewXMain.TabIndex = 23;
            // 
            // PriceName
            // 
            this.PriceName.DataPropertyName = "PriceName";
            this.PriceName.HeaderText = "价格方案名";
            this.PriceName.Name = "PriceName";
            // 
            // HostChannelName
            // 
            this.HostChannelName.DataPropertyName = "HostChannelName";
            this.HostChannelName.HeaderText = "渠道名称";
            this.HostChannelName.Name = "HostChannelName";
            // 
            // HostProductName
            // 
            this.HostProductName.DataPropertyName = "HostProductName";
            this.HostProductName.HeaderText = "产品名称";
            this.HostProductName.Name = "HostProductName";
            // 
            // GoodsType
            // 
            this.GoodsType.DataPropertyName = "GoodsTypeName";
            this.GoodsType.HeaderText = "货物类型";
            this.GoodsType.Name = "GoodsType";
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "状态";
            this.StatusName.Name = "StatusName";
            // 
            // EffectBegin
            // 
            this.EffectBegin.DataPropertyName = "EffectBegin";
            this.EffectBegin.HeaderText = "起效时间";
            this.EffectBegin.Name = "EffectBegin";
            // 
            // EffectEnd
            // 
            this.EffectEnd.DataPropertyName = "EffectEnd";
            this.EffectEnd.HeaderText = "失效时间";
            this.EffectEnd.Name = "EffectEnd";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            // 
            // CreateOpName
            // 
            this.CreateOpName.DataPropertyName = "CreateOpName";
            this.CreateOpName.HeaderText = "创建人";
            this.CreateOpName.Name = "CreateOpName";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockTabStripHeight = 30;
            this.bar1.Font = new System.Drawing.Font("华文宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar1.HideFloatingInactive = false;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnUpdate,
            this.btnDel,
            this.btnDetail,
            this.buttonItemSend,
            this.btnSaveASCost,
            this.btnSaveASSale,
            this.btnSaveASPublish,
            this.btnSaveASAgree});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1206, 31);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 22;
            this.bar1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BeginGroup = true;
            this.btnAdd.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Text = "查看明细";
            this.btnDetail.Visible = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // buttonItemSend
            // 
            this.buttonItemSend.Name = "buttonItemSend";
            this.buttonItemSend.Text = "发布";
            this.buttonItemSend.Click += new System.EventHandler(this.buttonItemSend_Click);
            // 
            // btnSaveASCost
            // 
            this.btnSaveASCost.Name = "btnSaveASCost";
            this.btnSaveASCost.Text = "另存为成本价";
            this.btnSaveASCost.Click += new System.EventHandler(this.btnSaveASCost_Click);
            // 
            // btnSaveASSale
            // 
            this.btnSaveASSale.Name = "btnSaveASSale";
            this.btnSaveASSale.Text = "另存为销售价";
            this.btnSaveASSale.Click += new System.EventHandler(this.btnSaveASSale_Click);
            // 
            // CostPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 600);
            this.Controls.Add(this.dataGridViewXMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bar1);
            this.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CostPriceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostPriceForm";
            this.Load += new System.EventHandler(this.CostPriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputValidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnSaveASAgree;
        private System.Windows.Forms.CheckBox cboxAllTime;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxExState;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputEnd;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputStart;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxProduct;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServiceChannel;
        private DevComponents.DotNetBar.ButtonX btnServiceChannel;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputValidate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnSaveASPublish;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXMain;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn PriceName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn HostChannelName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn HostProductName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn GoodsType;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn StatusName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn EffectBegin;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn EffectEnd;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn CreateTime;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn CreateOpName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ID;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnUpdate;
        private DevComponents.DotNetBar.ButtonItem btnDel;
        private DevComponents.DotNetBar.ButtonItem btnDetail;
        private DevComponents.DotNetBar.ButtonItem buttonItemSend;
        private DevComponents.DotNetBar.ButtonItem btnSaveASCost;
        private DevComponents.DotNetBar.ButtonItem btnSaveASSale;
    }
}