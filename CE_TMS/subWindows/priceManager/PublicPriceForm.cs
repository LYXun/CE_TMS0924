using CES_TMS.COMMON;
using CES_TMS.MODEL;
using CES_TMS.subWindows.dialog;
using HYTMS.MODEL;
using Newtonsoft.Json.Linq;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.subWindows.priceManager
{
    public partial class PublicPriceForm : Form
    {
        public PublicPriceForm()
        {
            InitializeComponent();
        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        #region 查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchAction();
        }

        private void searchAction()
        {
            try
            {
                string url = ServicesAPIHelper.Instance.PriceQueryPricesUrl;
                url = string.Format("{0}?ServiceKey={1}", url, PriceServicesKey.PublishPrice.ToString());
                string paramsStr = GetSearchParams();
                var dataStr = COMMON.NetHelper.HttpApi(url, paramsStr, "post");
                TmsReturnBaseObj<TmsPublishPirceDTO> parentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsPublishPirceDTO>>(dataStr);
                var list = parentObj.GetJsonList();
                if (list == null || list.Count < 1)
                {
                    CommonHelper.Instance.ShowToast(this, "没有记录行");
                }
                else
                {
                    list = list.OrderByDescending(o => o.CreateTime).ToList(); //时间降序
                }

                this.dataGridViewXMain.DataSource = list;
            }
            catch (Exception ex)
            {
                ThreadPool.QueueUserWorkItem(a => {
                    CommonHelper.Instance.ShowAlert(ex.Message);
                    CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message.ToString());
                });
            }
        }

        private string GetSearchParams()
        {
            string productCode = "";
            string state = "";

            if (comboBoxExState.SelectedItem != null)
            {
                state = (comboBoxExState.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
            }
            if (comboBoxProduct.SelectedItem != null)
            {
                var product = comboBoxProduct.SelectedItem as TmsServiceProduct;
                productCode = product.ProductCode;
            }
            if (string.IsNullOrEmpty(state) || int.Parse(state) == 0)
            {
                state = "";
            }

            dynamic searchObj = new JObject();
            //searchObj.priceType = ((int)PriceType.公布).ToString();
            searchObj.productCode = productCode;
            searchObj.channelCode = txtServiceChannel.Text;
            searchObj.priceCode = "";
            searchObj.status = state;

            if (cboxAllTime.Checked)
            {
                searchObj.effectTime = ((DateTime)SqlDateTime.MinValue).ToLocalTime();
                searchObj.start = ((DateTime)SqlDateTime.MinValue).ToLocalTime();
                searchObj.end = ((DateTime)SqlDateTime.MaxValue).ToLocalTime();
            }
            else
            {
                searchObj.effectTime = DateTime.Parse(string.Format(@"{0}", this.dateTimeInputValidate.Text)).ToLocalTime();
                searchObj.start = DateTime.Parse(string.Format(@"{0} {1}", this.dateTimeInputStart.Text, "00:00:00")).ToLocalTime();
                searchObj.end = DateTime.Parse(string.Format(@"{0} {1}", this.dateTimeInputEnd.Text, "23:59:59")).ToLocalTime();
            }

            searchObj.pageSize = "0";
            searchObj.pageIndex = "1";

            return searchObj.ToString();
        }
        #endregion

        #region 窗体加载
        private void PublicPriceForm_Load(object sender, EventArgs e)
        {
            dateTimeInputStart.Value = DateTime.Now.AddDays(-7);
            dateTimeInputEnd.Value = DateTime.Now;
            dateTimeInputValidate.Value = DateTime.Now.AddDays(5);
            this.dataGridViewXMain.AutoGenerateColumns = false;
            this.comboBoxExState.SelectedIndex = 0;
            this.dataGridViewXMain.RowStateChanged += DataGridViewXMain_RowStateChanged;
        }

        private void DataGridViewXMain_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
        #endregion

        #region 选择服务商渠道
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
