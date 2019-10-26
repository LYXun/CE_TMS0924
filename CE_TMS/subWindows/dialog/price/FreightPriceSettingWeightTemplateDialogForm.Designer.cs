namespace CES_TMS.subWindows.dialog.price
{
    partial class FreightPriceSettingWeightTemplateDialogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewLabelXColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.BigZoneName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.dataGridViewXLeft = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BigZoneID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出表格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewXMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BgZoneName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ZoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StartWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ZoneID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.btnPrev = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDel = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtWeightName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXLeft)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLabelXColumn2
            // 
            this.dataGridViewLabelXColumn2.DataPropertyName = "ID";
            this.dataGridViewLabelXColumn2.HeaderText = "ID";
            this.dataGridViewLabelXColumn2.Name = "dataGridViewLabelXColumn2";
            this.dataGridViewLabelXColumn2.Visible = false;
            // 
            // BigZoneName
            // 
            this.BigZoneName.DataPropertyName = "BigZoneName";
            this.BigZoneName.HeaderText = "分区名称";
            this.BigZoneName.Name = "BigZoneName";
            // 
            // dataGridViewXLeft
            // 
            this.dataGridViewXLeft.AllowUserToAddRows = false;
            this.dataGridViewXLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXLeft.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BigZoneName,
            this.BigZoneID,
            this.dataGridViewLabelXColumn2});
            this.dataGridViewXLeft.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXLeft.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewXLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewXLeft.EnableHeadersVisualStyles = false;
            this.dataGridViewXLeft.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewXLeft.Location = new System.Drawing.Point(0, 95);
            this.dataGridViewXLeft.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXLeft.Name = "dataGridViewXLeft";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXLeft.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewXLeft.RowHeadersWidth = 65;
            this.dataGridViewXLeft.RowTemplate.Height = 23;
            this.dataGridViewXLeft.Size = new System.Drawing.Size(384, 556);
            this.dataGridViewXLeft.TabIndex = 32;
            // 
            // BigZoneID
            // 
            this.BigZoneID.DataPropertyName = "BigZoneID";
            this.BigZoneID.HeaderText = "BigZoneID";
            this.BigZoneID.Name = "BigZoneID";
            this.BigZoneID.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.替换ToolStripMenuItem,
            this.导出表格ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 替换ToolStripMenuItem
            // 
            this.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem";
            this.替换ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.替换ToolStripMenuItem.Text = "替换";
            // 
            // 导出表格ToolStripMenuItem
            // 
            this.导出表格ToolStripMenuItem.Name = "导出表格ToolStripMenuItem";
            this.导出表格ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出表格ToolStripMenuItem.Text = "导出表格";
            // 
            // dataGridViewXMain
            // 
            this.dataGridViewXMain.AllowUserToAddRows = false;
            this.dataGridViewXMain.AllowUserToDeleteRows = false;
            this.dataGridViewXMain.AllowUserToResizeRows = false;
            this.dataGridViewXMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewXMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.BgZoneName,
            this.ZoneName,
            this.PayType,
            this.StartWeight,
            this.EndWeight,
            this.SignWeight,
            this.ID,
            this.ZoneID});
            this.dataGridViewXMain.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXMain.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewXMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXMain.EnableHeadersVisualStyles = false;
            this.dataGridViewXMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewXMain.Location = new System.Drawing.Point(384, 95);
            this.dataGridViewXMain.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXMain.Name = "dataGridViewXMain";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewXMain.RowHeadersWidth = 65;
            this.dataGridViewXMain.RowTemplate.Height = 23;
            this.dataGridViewXMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXMain.Size = new System.Drawing.Size(756, 556);
            this.dataGridViewXMain.TabIndex = 31;
            // 
            // Checked
            // 
            this.Checked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Checked.FalseValue = "false";
            this.Checked.FillWeight = 50.76142F;
            this.Checked.HeaderText = "全选";
            this.Checked.MinimumWidth = 6;
            this.Checked.Name = "Checked";
            this.Checked.TrueValue = "true";
            this.Checked.Width = 50;
            // 
            // BgZoneName
            // 
            this.BgZoneName.HeaderText = "分区名称";
            this.BgZoneName.Name = "BgZoneName";
            // 
            // ZoneName
            // 
            this.ZoneName.DataPropertyName = "ZoneName";
            this.ZoneName.FillWeight = 112.3096F;
            this.ZoneName.HeaderText = "重量段标题";
            this.ZoneName.Name = "ZoneName";
            this.ZoneName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PayType
            // 
            this.PayType.FillWeight = 112.3096F;
            this.PayType.HeaderText = "计费种类";
            this.PayType.Items.AddRange(new object[] {
            "单价",
            "总价"});
            this.PayType.Name = "PayType";
            this.PayType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StartWeight
            // 
            this.StartWeight.FillWeight = 112.3096F;
            this.StartWeight.HeaderText = "开始重量";
            this.StartWeight.Name = "StartWeight";
            this.StartWeight.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndWeight
            // 
            this.EndWeight.FillWeight = 112.3096F;
            this.EndWeight.HeaderText = "截止重量";
            this.EndWeight.Name = "EndWeight";
            this.EndWeight.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EndWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SignWeight
            // 
            this.SignWeight.HeaderText = "计费单重";
            this.SignWeight.Name = "SignWeight";
            this.SignWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ZoneID
            // 
            this.ZoneID.DataPropertyName = "BigZoneID";
            this.ZoneID.HeaderText = "分区ID";
            this.ZoneID.Name = "ZoneID";
            this.ZoneID.Visible = false;
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrev.Location = new System.Drawing.Point(22, 12);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(108, 33);
            this.btnPrev.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrev.TabIndex = 19;
            this.btnPrev.Text = "上一步";
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Location = new System.Drawing.Point(760, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 33);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "下一步";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(874, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "关闭";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 57);
            this.panel2.TabIndex = 30;
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Text = "删除";
            // 
            // btnAdd
            // 
            this.btnAdd.BeginGroup = true;
            this.btnAdd.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "新增";
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
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.HideFloatingInactive = false;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnDel});
            this.bar1.Location = new System.Drawing.Point(0, 68);
            this.bar1.Margin = new System.Windows.Forms.Padding(0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1140, 27);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 17;
            this.bar1.TabStop = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX3.Location = new System.Drawing.Point(36, 20);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(112, 31);
            this.labelX3.TabIndex = 23;
            this.labelX3.Text = "重量模板";
            // 
            // txtWeightName
            // 
            // 
            // 
            // 
            this.txtWeightName.Border.Class = "TextBoxBorder";
            this.txtWeightName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWeightName.Location = new System.Drawing.Point(294, 20);
            this.txtWeightName.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeightName.Name = "txtWeightName";
            this.txtWeightName.PreventEnterBeep = true;
            this.txtWeightName.Size = new System.Drawing.Size(402, 26);
            this.txtWeightName.TabIndex = 22;
            this.txtWeightName.Visible = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX2.Location = new System.Drawing.Point(183, 20);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 31);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "模板名称";
            this.labelX2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.txtWeightName);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 68);
            this.panel1.TabIndex = 28;
            // 
            // FreightPriceSettingWeightTemplateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 708);
            this.Controls.Add(this.dataGridViewXMain);
            this.Controls.Add(this.dataGridViewXLeft);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FreightPriceSettingWeightTemplateDialogForm";
            this.Text = "运费价格设置-重量模板";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXLeft)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn dataGridViewLabelXColumn2;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn BigZoneName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXLeft;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn BigZoneID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出表格ToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXMain;
        private DevComponents.DotNetBar.ButtonX btnPrev;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonItem btnDel;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWeightName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn BgZoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZoneName;
        private System.Windows.Forms.DataGridViewComboBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignWeight;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ID;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ZoneID;
    }
}