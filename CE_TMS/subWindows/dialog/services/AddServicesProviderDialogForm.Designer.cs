namespace CES_TMS.subWindows.dialog.services
{
    partial class AddServicesProviderDialogForm
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
            this.radioButtonStatus2 = new System.Windows.Forms.RadioButton();
            this.radioButtonStatus = new System.Windows.Forms.RadioButton();
            this.comboBoxExOrgID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtTel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // radioButtonStatus2
            // 
            this.radioButtonStatus2.AutoSize = true;
            this.radioButtonStatus2.Location = new System.Drawing.Point(239, 409);
            this.radioButtonStatus2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonStatus2.Name = "radioButtonStatus2";
            this.radioButtonStatus2.Size = new System.Drawing.Size(54, 20);
            this.radioButtonStatus2.TabIndex = 38;
            this.radioButtonStatus2.Text = "失效";
            this.radioButtonStatus2.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatus
            // 
            this.radioButtonStatus.AutoSize = true;
            this.radioButtonStatus.Checked = true;
            this.radioButtonStatus.Location = new System.Drawing.Point(159, 409);
            this.radioButtonStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonStatus.Name = "radioButtonStatus";
            this.radioButtonStatus.Size = new System.Drawing.Size(54, 20);
            this.radioButtonStatus.TabIndex = 39;
            this.radioButtonStatus.TabStop = true;
            this.radioButtonStatus.Text = "生效";
            this.radioButtonStatus.UseVisualStyleBackColor = true;
            // 
            // comboBoxExOrgID
            // 
            this.comboBoxExOrgID.DisplayMember = "Text";
            this.comboBoxExOrgID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxExOrgID.FormattingEnabled = true;
            this.comboBoxExOrgID.ItemHeight = 21;
            this.comboBoxExOrgID.Location = new System.Drawing.Point(162, 351);
            this.comboBoxExOrgID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxExOrgID.Name = "comboBoxExOrgID";
            this.comboBoxExOrgID.Size = new System.Drawing.Size(244, 27);
            this.comboBoxExOrgID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxExOrgID.TabIndex = 37;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(273, 466);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 33);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(143, 466);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 33);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTel
            // 
            // 
            // 
            // 
            this.txtTel.Border.Class = "TextBoxBorder";
            this.txtTel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTel.Location = new System.Drawing.Point(161, 301);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.MaxLength = 20;
            this.txtTel.Name = "txtTel";
            this.txtTel.PreventEnterBeep = true;
            this.txtTel.Size = new System.Drawing.Size(328, 26);
            this.txtTel.TabIndex = 33;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(159, 193);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.Size = new System.Drawing.Size(330, 87);
            this.txtAddress.TabIndex = 32;
            // 
            // txtFName
            // 
            // 
            // 
            // 
            this.txtFName.Border.Class = "TextBoxBorder";
            this.txtFName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFName.Location = new System.Drawing.Point(159, 141);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFName.MaxLength = 200;
            this.txtFName.Name = "txtFName";
            this.txtFName.PreventEnterBeep = true;
            this.txtFName.Size = new System.Drawing.Size(330, 26);
            this.txtFName.TabIndex = 34;
            // 
            // txtSName
            // 
            // 
            // 
            // 
            this.txtSName.Border.Class = "TextBoxBorder";
            this.txtSName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSName.Location = new System.Drawing.Point(159, 88);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSName.MaxLength = 100;
            this.txtSName.Name = "txtSName";
            this.txtSName.PreventEnterBeep = true;
            this.txtSName.Size = new System.Drawing.Size(330, 26);
            this.txtSName.TabIndex = 31;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.Border.Class = "TextBoxBorder";
            this.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCode.Location = new System.Drawing.Point(159, 42);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.MaxLength = 100;
            this.txtCode.Name = "txtCode";
            this.txtCode.PreventEnterBeep = true;
            this.txtCode.Size = new System.Drawing.Size(330, 26);
            this.txtCode.TabIndex = 30;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX7.Location = new System.Drawing.Point(31, 352);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(107, 31);
            this.labelX7.TabIndex = 28;
            this.labelX7.Text = "所属机构组织";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX6.Location = new System.Drawing.Point(53, 298);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(88, 31);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "服务商电话";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX5.Location = new System.Drawing.Point(53, 403);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(88, 31);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "服务商状态";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX4.Location = new System.Drawing.Point(53, 198);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(88, 31);
            this.labelX4.TabIndex = 25;
            this.labelX4.Text = "服务商地址";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX3.Location = new System.Drawing.Point(53, 139);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(88, 31);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "服务商全称";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX2.Location = new System.Drawing.Point(53, 88);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(88, 31);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "服务商简称";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX1.Location = new System.Drawing.Point(53, 42);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(88, 31);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "服务商代码";
            // 
            // AddServicesProviderDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 544);
            this.Controls.Add(this.radioButtonStatus2);
            this.Controls.Add(this.radioButtonStatus);
            this.Controls.Add(this.comboBoxExOrgID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddServicesProviderDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加服务商";
            this.Load += new System.EventHandler(this.AddServicesProviderDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonStatus2;
        private System.Windows.Forms.RadioButton radioButtonStatus;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxExOrgID;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCode;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}