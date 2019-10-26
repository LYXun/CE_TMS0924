namespace CES_TMS.subWindows.priceManager
{
    partial class ZoneManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Remark = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ZoneName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewXMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.StatusName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.buttonItemDetail = new DevComponents.DotNetBar.ButtonItem();
            this.btnPublish = new DevComponents.DotNetBar.ButtonItem();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.textBoxZoneName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxExStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 23;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 119.0722F;
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.Width = 250;
            // 
            // ZoneName
            // 
            this.ZoneName.DataPropertyName = "ZoneName";
            this.ZoneName.FillWeight = 119.0722F;
            this.ZoneName.HeaderText = "分区方案名称";
            this.ZoneName.Name = "ZoneName";
            this.ZoneName.Width = 250;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 61.85567F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // dataGridViewXMain
            // 
            this.dataGridViewXMain.AllowUserToAddRows = false;
            this.dataGridViewXMain.AllowUserToDeleteRows = false;
            this.dataGridViewXMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ZoneName,
            this.Remark,
            this.StatusName,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewXMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXMain.EnableHeadersVisualStyles = false;
            this.dataGridViewXMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewXMain.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewXMain.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXMain.Name = "dataGridViewXMain";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewXMain.RowHeadersWidth = 65;
            this.dataGridViewXMain.RowTemplate.Height = 23;
            this.dataGridViewXMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXMain.Size = new System.Drawing.Size(1200, 510);
            this.dataGridViewXMain.TabIndex = 21;
            // 
            // StatusName
            // 
            this.StatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "状态";
            this.StatusName.Name = "StatusName";
            // 
            // buttonItemDetail
            // 
            this.buttonItemDetail.Name = "buttonItemDetail";
            this.buttonItemDetail.Text = "查看明细";
            this.buttonItemDetail.Click += new System.EventHandler(this.buttonItemDetail_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Text = "发布";
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BeginGroup = true;
            this.btnAdd.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "新增分区方案";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.bar1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar1.HideFloatingInactive = false;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnUpdate,
            this.btnPublish,
            this.buttonItemDetail});
            this.bar1.Location = new System.Drawing.Point(0, 59);
            this.bar1.Margin = new System.Windows.Forms.Padding(0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1200, 31);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 20;
            this.bar1.TabStop = false;
            // 
            // textBoxZoneName
            // 
            // 
            // 
            // 
            this.textBoxZoneName.Border.Class = "TextBoxBorder";
            this.textBoxZoneName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxZoneName.Location = new System.Drawing.Point(533, 18);
            this.textBoxZoneName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZoneName.Name = "textBoxZoneName";
            this.textBoxZoneName.PreventEnterBeep = true;
            this.textBoxZoneName.Size = new System.Drawing.Size(400, 26);
            this.textBoxZoneName.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(1003, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 33);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX1.Location = new System.Drawing.Point(18, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(94, 31);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "分区状态";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "发布";
            this.comboItem3.Value = "2";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "草稿";
            this.comboItem2.Value = "1";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "全部";
            this.comboItem1.Value = "3";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX6.Location = new System.Drawing.Point(409, 18);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(107, 31);
            this.labelX6.TabIndex = 22;
            this.labelX6.Text = "分区方案名称";
            // 
            // comboBoxExStatus
            // 
            this.comboBoxExStatus.DisplayMember = "Text";
            this.comboBoxExStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxExStatus.FormattingEnabled = true;
            this.comboBoxExStatus.ItemHeight = 21;
            this.comboBoxExStatus.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.comboBoxExStatus.Location = new System.Drawing.Point(125, 17);
            this.comboBoxExStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExStatus.Name = "comboBoxExStatus";
            this.comboBoxExStatus.Size = new System.Drawing.Size(247, 27);
            this.comboBoxExStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxExStatus.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.comboBoxExStatus);
            this.panel1.Controls.Add(this.textBoxZoneName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 59);
            this.panel1.TabIndex = 19;
            // 
            // ZoneManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dataGridViewXMain);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZoneManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分区管理";
            this.Load += new System.EventHandler(this.ZoneManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ID;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Remark;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ZoneName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXMain;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn StatusName;
        private DevComponents.DotNetBar.ButtonItem buttonItemDetail;
        private DevComponents.DotNetBar.ButtonItem btnPublish;
        private DevComponents.DotNetBar.ButtonItem btnUpdate;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxZoneName;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxExStatus;
        private System.Windows.Forms.Panel panel1;
    }
}