namespace CES_TMS.subWindows.dialog.price
{
    partial class ChangeAreaZoneDialogForm
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
            this.dataGridViewXMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ZoneName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Remark = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXMain
            // 
            this.dataGridViewXMain.AllowUserToAddRows = false;
            this.dataGridViewXMain.AllowUserToDeleteRows = false;
            this.dataGridViewXMain.AllowUserToResizeRows = false;
            this.dataGridViewXMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZoneName,
            this.Remark,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewXMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXMain.EnableHeadersVisualStyles = false;
            this.dataGridViewXMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewXMain.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewXMain.Name = "dataGridViewXMain";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewXMain.RowHeadersWidth = 65;
            this.dataGridViewXMain.RowTemplate.Height = 23;
            this.dataGridViewXMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXMain.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewXMain.TabIndex = 21;
            this.dataGridViewXMain.DoubleClick += new System.EventHandler(this.dataGridViewXMain_DoubleClick);
            // 
            // ZoneName
            // 
            this.ZoneName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ZoneName.DataPropertyName = "ZoneName";
            this.ZoneName.HeaderText = "分区方案名称";
            this.ZoneName.Name = "ZoneName";
            this.ZoneName.TextAlignment = System.Drawing.StringAlignment.Far;
            this.ZoneName.Width = 400;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ChangeAreaZoneDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewXMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeAreaZoneDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分区方案名称";
            this.Load += new System.EventHandler(this.ChangeAreaZoneDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXMain;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ZoneName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Remark;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ID;
    }
}