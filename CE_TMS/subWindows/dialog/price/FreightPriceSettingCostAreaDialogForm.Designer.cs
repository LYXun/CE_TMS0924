namespace CES_TMS.subWindows.dialog.price
{
    partial class FreightPriceSettingCostAreaDialogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.导出表格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BigZoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSetZipCodeZone = new DevComponents.DotNetBar.ButtonItem();
            this.btnDel = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddCountry = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddZone = new DevComponents.DotNetBar.ButtonItem();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.txtRemark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAreaName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewXMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).BeginInit();
            this.SuspendLayout();
            // 
            // 导出表格ToolStripMenuItem
            // 
            this.导出表格ToolStripMenuItem.Name = "导出表格ToolStripMenuItem";
            this.导出表格ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出表格ToolStripMenuItem.Text = "导出表格";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.替换ToolStripMenuItem,
            this.导出表格ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(125, 92);
            // 
            // 替换ToolStripMenuItem
            // 
            this.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem";
            this.替换ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.替换ToolStripMenuItem.Text = "替换";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TypeName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Type.DefaultCellStyle = dataGridViewCellStyle8;
            this.Type.FillWeight = 112.3096F;
            this.Type.HeaderText = "方案类型";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Type.Width = 221;
            // 
            // CountryName
            // 
            this.CountryName.DataPropertyName = "CountryName";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CountryName.DefaultCellStyle = dataGridViewCellStyle9;
            this.CountryName.FillWeight = 112.3096F;
            this.CountryName.HeaderText = "国家名称";
            this.CountryName.Name = "CountryName";
            this.CountryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CountryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CountryName.Width = 222;
            // 
            // CountryCode
            // 
            this.CountryCode.DataPropertyName = "CountryCode";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CountryCode.DefaultCellStyle = dataGridViewCellStyle10;
            this.CountryCode.FillWeight = 112.3096F;
            this.CountryCode.HeaderText = "国家代码";
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CountryCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CountryCode.Width = 221;
            // 
            // BigZoneName
            // 
            this.BigZoneName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BigZoneName.DataPropertyName = "BigZoneName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BigZoneName.DefaultCellStyle = dataGridViewCellStyle11;
            this.BigZoneName.FillWeight = 112.3096F;
            this.BigZoneName.HeaderText = "分区名称";
            this.BigZoneName.Name = "BigZoneName";
            this.BigZoneName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BigZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BigZoneName.Width = 120;
            // 
            // Checked
            // 
            this.Checked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Checked.FalseValue = "false";
            this.Checked.FillWeight = 50.76142F;
            this.Checked.HeaderText = "全选";
            this.Checked.Name = "Checked";
            this.Checked.TrueValue = "true";
            this.Checked.Width = 35;
            // 
            // btnSetZipCodeZone
            // 
            this.btnSetZipCodeZone.Name = "btnSetZipCodeZone";
            this.btnSetZipCodeZone.Text = "设置邮编段";
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Text = "删除";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Text = "添加国家";
            this.btnAddCountry.Visible = false;
            // 
            // btnAddZone
            // 
            this.btnAddZone.BeginGroup = true;
            this.btnAddZone.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.btnAddZone.Name = "btnAddZone";
            this.btnAddZone.Text = "自定义分区";
            this.btnAddZone.Click += new System.EventHandler(this.btnAddZone_Click);
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar1.DockTabStripHeight = 30;
            this.bar1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar1.HideFloatingInactive = false;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddZone,
            this.btnAddCountry,
            this.btnDel,
            this.btnSetZipCodeZone});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(987, 31);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 17;
            this.bar1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 39);
            this.panel3.TabIndex = 26;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Location = new System.Drawing.Point(707, 11);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 33);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "保存";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 57);
            this.panel2.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(832, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 33);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Location = new System.Drawing.Point(763, 24);
            this.checkBoxSave.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(97, 20);
            this.checkBoxSave.TabIndex = 19;
            this.checkBoxSave.Text = "保存并发布";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemark.Location = new System.Drawing.Point(495, 19);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.PreventEnterBeep = true;
            this.txtRemark.Size = new System.Drawing.Size(260, 27);
            this.txtRemark.TabIndex = 18;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX3.Location = new System.Drawing.Point(429, 19);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(57, 31);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "备注";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSave);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.txtAreaName);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 62);
            this.panel1.TabIndex = 24;
            // 
            // txtAreaName
            // 
            // 
            // 
            // 
            this.txtAreaName.Border.Class = "TextBoxBorder";
            this.txtAreaName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAreaName.Location = new System.Drawing.Point(144, 18);
            this.txtAreaName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaName.Multiline = true;
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.PreventEnterBeep = true;
            this.txtAreaName.Size = new System.Drawing.Size(266, 27);
            this.txtAreaName.TabIndex = 18;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX2.Location = new System.Drawing.Point(35, 18);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(99, 31);
            this.labelX2.TabIndex = 17;
            this.labelX2.Text = "分区方案名称";
            // 
            // dataGridViewXMain
            // 
            this.dataGridViewXMain.AllowUserToAddRows = false;
            this.dataGridViewXMain.AllowUserToOrderColumns = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewXMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.BigZoneName,
            this.CountryCode,
            this.CountryName,
            this.Type,
            this.ID});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXMain.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewXMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXMain.EnableHeadersVisualStyles = false;
            this.dataGridViewXMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewXMain.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewXMain.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXMain.MultiSelect = false;
            this.dataGridViewXMain.Name = "dataGridViewXMain";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewXMain.RowHeadersWidth = 65;
            this.dataGridViewXMain.RowTemplate.Height = 23;
            this.dataGridViewXMain.Size = new System.Drawing.Size(987, 600);
            this.dataGridViewXMain.TabIndex = 27;
            // 
            // FreightPriceSettingCostAreaDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewXMain);
            this.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FreightPriceSettingCostAreaDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运费价格设置-价格分区";
            this.Load += new System.EventHandler(this.FreightPriceSettingCostAreaDialogForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 导出表格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 替换ToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BigZoneName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private DevComponents.DotNetBar.ButtonItem btnSetZipCodeZone;
        private DevComponents.DotNetBar.ButtonItem btnDel;
        private DevComponents.DotNetBar.ButtonItem btnAddCountry;
        private DevComponents.DotNetBar.ButtonItem btnAddZone;
        private DevComponents.DotNetBar.Bar bar1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemark;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAreaName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXMain;
    }
}