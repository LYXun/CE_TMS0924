using CES_TMS.COMMON;
using CES_TMS.subWindows.dialog;
using CES_TMS.subWindows.dialog.price;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.subWindows.priceManager
{
    public partial class CostPriceForm : Form
    {
        public CostPriceForm()
        {
            InitializeComponent();
        }

        #region 窗体加载
        private void CostPriceForm_Load(object sender, EventArgs e)
        {
            dateTimeInputStart.Value = DateTime.Now.AddDays(-7);
            dateTimeInputEnd.Value = DateTime.Now;
            dateTimeInputValidate.Value = DateTime.Now.AddDays(5);
            this.comboBoxExState.SelectedIndex = 0;
            this.dataGridViewXMain.AutoGenerateColumns = false;
            this.dataGridViewXMain.RowStateChanged += DataGridViewXMain_RowStateChanged;
        }

        private void DataGridViewXMain_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
        #endregion

        #region 服务渠道
        private void btnServiceChannel_Click(object sender, EventArgs e)
        {
            if (this.comboBoxProduct.Items.Count > 0)
            {
                this.comboBoxProduct.DataSource = null;
                this.comboBoxProduct.Items.Clear();
            }
            using (ServiceChannelDialogForm channelDialogForm = new ServiceChannelDialogForm())
            {
                channelDialogForm.ChangeChannelEvent += ChannelDialogForm_ChangeChannelEvent;
                channelDialogForm.ShowDialog();
            }
        }

        private void ChannelDialogForm_ChangeChannelEvent(string serviceChannel, string serviceChannelName)
        {
            txtServiceChannel.Text = serviceChannel;
            //填充销售产品数据
            if (!string.IsNullOrEmpty(serviceChannel))
            {
                var plist = UIHelper.Instance.GetProductList(serviceChannel);
                UIHelper.Instance.BindComboxData(comboBoxProduct, plist, "PRODUCTFULLNAME", "PRODUCTCODE");
            }
        }
        #endregion

        #region 添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCostDiaLogForm costDialog = new AddCostDiaLogForm(); 
            costDialog.Show();
        } 
        #endregion

        #region 修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 删除
        private void btnDel_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 查看明细
        private void btnDetail_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 发布
        private void buttonItemSend_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 另存为成本价
        private void btnSaveASCost_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 另存为销售价
        private void btnSaveASSale_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 另存为公布价
        private void btnSaveASPublish_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 另存为协议价
        private void btnSaveASAgree_Click(object sender, EventArgs e)
        {

        } 
        #endregion
    }
}
