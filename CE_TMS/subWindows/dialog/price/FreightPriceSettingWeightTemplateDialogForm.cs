using CES_TMS.COMMON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.subWindows.dialog.price
{
    public partial class FreightPriceSettingWeightTemplateDialogForm : Form
    {
        private object changeCountryName;
        private object bigZoneId;

        public FreightPriceSettingWeightTemplateDialogForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void AddRow()
        {
            int rowIndex = this.dataGridViewXMain.Rows.Add();
            this.dataGridViewXMain.Rows[rowIndex].Cells[1].Value = changeCountryName;
            this.dataGridViewXMain.Rows[rowIndex].Cells[2].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells[3].Value = "单价";
            this.dataGridViewXMain.Rows[rowIndex].Cells[4].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells[5].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells[6].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells["ZoneID"].Value = this.bigZoneId;
        }

        private void FreightPriceSettingWeightTemplateDialogForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewXMain.DataError += DataGridViewXMain_DataError;
            this.dataGridViewXMain.RowStateChanged += DataGridViewXMain_RowStateChanged;
            this.dataGridViewXLeft.RowStateChanged += DataGridViewXMain_RowStateChanged;
        }

        private void DataGridViewXMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DataGridViewXMain_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClosing_Click(object sender, EventArgs e)
        {
            //弹出警告框 
            if (DialogResult.OK == MessageBox.Show(string.Format("当前价格表没有设置完成，是否要退出？"), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                //关闭所有关联窗体
                CommonHelper.Instance.ClearPriceTemplateObjectsCache();
                string[] formAry = { "FreightPriceSettingWeightTemplateDialogForm", "FreightPriceSettingPriceDialogForm" };
                UIHelper.Instance.CloseForm(formAry);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }
    }
}
