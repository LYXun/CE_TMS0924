namespace CE_TMS.subWindows.servicesManager
{
    partial class ServicesProviderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnUp = new DevComponents.DotNetBar.ButtonItem();
            this.cmbOrgID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtServiceCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ServiceCode = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ServiceShortName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ServiceFullName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ServiceType = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.HostOrgName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ServiceTel = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ServiceAddress = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.StatusName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.CreateTime = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.生效 = new DevComponents.Editors.ComboItem();
            this.失效 = new DevComponents.Editors.ComboItem();
            this.所有 = new DevComponents.Editors.ComboItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtServiceCode);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.cmbOrgID);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 101);
            this.panel1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(10, 14);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(116, 31);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "所属自组织机构";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(344, 14);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(121, 31);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "服务商代码 名称";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(10, 58);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(116, 31);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "服务商状态";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnUp});
            this.bar1.Location = new System.Drawing.Point(0, 101);
            this.bar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1098, 27);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUp
            // 
            this.btnUp.Name = "btnUp";
            this.btnUp.Text = "修改";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // cmbOrgID
            // 
            this.cmbOrgID.DisplayMember = "Text";
            this.cmbOrgID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrgID.FormattingEnabled = true;
            this.cmbOrgID.ItemHeight = 21;
            this.cmbOrgID.Location = new System.Drawing.Point(139, 16);
            this.cmbOrgID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOrgID.Name = "cmbOrgID";
            this.cmbOrgID.Size = new System.Drawing.Size(179, 27);
            this.cmbOrgID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbOrgID.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Text";
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 21;
            this.cmbStatus.Items.AddRange(new object[] {
            this.生效,
            this.失效,
            this.所有});
            this.cmbStatus.Location = new System.Drawing.Point(139, 58);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(179, 27);
            this.cmbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbStatus.TabIndex = 4;
            // 
            // txtServiceCode
            // 
            // 
            // 
            // 
            this.txtServiceCode.Border.Class = "TextBoxBorder";
            this.txtServiceCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtServiceCode.Location = new System.Drawing.Point(485, 16);
            this.txtServiceCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServiceCode.Name = "txtServiceCode";
            this.txtServiceCode.PreventEnterBeep = true;
            this.txtServiceCode.Size = new System.Drawing.Size(269, 26);
            this.txtServiceCode.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(931, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "查询";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ServiceCode,
            this.ServiceShortName,
            this.ServiceFullName,
            this.ServiceType,
            this.HostOrgName,
            this.ServiceTel,
            this.ServiceAddress,
            this.StatusName,
            this.CreateTime});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 128);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(1098, 519);
            this.dataGridViewX1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ServiceCode
            // 
            this.ServiceCode.DataPropertyName = "ServiceCode";
            this.ServiceCode.HeaderText = "服务商代码";
            this.ServiceCode.Name = "ServiceCode";
            // 
            // ServiceShortName
            // 
            this.ServiceShortName.DataPropertyName = "ServiceShortName";
            this.ServiceShortName.HeaderText = "服务商简称";
            this.ServiceShortName.Name = "ServiceShortName";
            // 
            // ServiceFullName
            // 
            this.ServiceFullName.DataPropertyName = "ServiceFullName";
            this.ServiceFullName.HeaderText = "服务商全称";
            this.ServiceFullName.Name = "ServiceFullName";
            // 
            // ServiceType
            // 
            this.ServiceType.DataPropertyName = "ServiceType";
            this.ServiceType.HeaderText = "服务商类型";
            this.ServiceType.Name = "ServiceType";
            // 
            // HostOrgName
            // 
            this.HostOrgName.DataPropertyName = "HostOrgName";
            this.HostOrgName.HeaderText = "所属组织";
            this.HostOrgName.Name = "HostOrgName";
            // 
            // ServiceTel
            // 
            this.ServiceTel.DataPropertyName = "ServiceTel";
            this.ServiceTel.HeaderText = "服务商电话";
            this.ServiceTel.Name = "ServiceTel";
            // 
            // ServiceAddress
            // 
            this.ServiceAddress.DataPropertyName = "ServiceAddress";
            this.ServiceAddress.HeaderText = "服务商地址";
            this.ServiceAddress.Name = "ServiceAddress";
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "状态";
            this.StatusName.Name = "StatusName";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            // 
            // 生效
            // 
            this.生效.Text = "生效";
            this.生效.Value = "1";
            // 
            // 失效
            // 
            this.失效.Text = "失效";
            this.失效.Value = "2";
            // 
            // 所有
            // 
            this.所有.Text = "所有";
            this.所有.Value = "3";
            // 
            // ServicesProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 647);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServicesProviderForm";
            this.Text = "ServicesProviderForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServiceCode;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStatus;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbOrgID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnUp;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ID;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ServiceCode;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ServiceShortName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ServiceFullName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ServiceType;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn HostOrgName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ServiceTel;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ServiceAddress;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn StatusName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn CreateTime;
        private DevComponents.Editors.ComboItem 生效;
        private DevComponents.Editors.ComboItem 失效;
        private DevComponents.Editors.ComboItem 所有;
    }
}