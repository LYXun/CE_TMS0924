using CES_TMS.COMMON;
using CES_TMS.MODEL;
using CES_TMS.subWindows.dialog.price;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
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
    public partial class ZoneManageForm : Form
    {
        public ZoneManageForm()
        {
            InitializeComponent();
        }

        private void ZoneManageForm_Load(object sender, EventArgs e)
        {
            dataGridViewXMain.RowStateChanged += DataGridViewXMain_RowStateChanged;
        }

        private void DataGridViewXMain_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}",e.Row.Index +1);
        }

        #region 查询事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchAction();
        }
        
        private void searchAction()
        {
            try
            {
                string url = ServicesAPIHelper.Instance.ZonePlanQueryListUrl;
                string paramsStr = GetSearchParams();
                var dataStr = NetHelper.HttpApi(url, paramsStr, "post");
                TmsReturnBaseObj<TmsPriceZone> parentObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsPriceZone>>(dataStr);
                var list = parentObj.GetJsonList();
                if (list == null || list.Count < 1)
                {
                    CommonHelper.Instance.ShowToast(this, "没有记录行");
                }
                this.dataGridViewXMain.AutoGenerateColumns = false;
                this.dataGridViewXMain.DataSource = list.OrderBy(o => o.ZoneName).ToList();
            }
            catch (Exception ex)
            {
                CommonHelper.Instance.ShowAlert(ex.Message);
                CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
            }
        }

        private string GetSearchParams()
        {
            string state = "";
            if (comboBoxExStatus.SelectedItem != null)
            {
                state = (comboBoxExStatus.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
            }
            dynamic searchObj = new JObject();
            searchObj.keyWord = textBoxZoneName.Text.Trim();
            searchObj.pageSize = "0";
            searchObj.pageIndex = "1";
            return searchObj.ToString();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FreightPriceSettingCostAreaDialogForm areaDialog = new FreightPriceSettingCostAreaDialogForm())
            {
                areaDialog.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewXMain.SelectedRows.Count >0)
            {
                if (this.dataGridViewXMain.SelectedRows[0].Cells["ID"].Value == null)
                {
                    return;
                }
                try
                {
                    string zid = this.dataGridViewXMain.SelectedRows[0].Cells["ID"].Value.ToString();
                    List<TmsPriceZone> list = this.dataGridViewXMain.DataSource as List<TmsPriceZone>;
                    TmsPriceZone zone = list.Find(i => i.Id.Equals(zid));
                    if (zone.Status.Equals(ZoneStatus.发布))
                    {
                        CommonHelper.Instance.ShowToast(this, "当前分区状态不能编辑");
                        return;
                    }
                    string url= ServicesAPIHelper.Instance.ZonePlanQueryPLanDetailByIdUrl;
                    dynamic searchObj = new JObject();
                    searchObj.id = zid;
                    string paramsStr = searchObj.ToString();
                    CommonHelper.Instance.LogHelperInfo(LogLevel.Info, string.Format("{0}-{1}", url, paramsStr));
                    var dataStr = COMMON.NetHelper.HttpApi(url, paramsStr, "post");
                    TmsReturnBaseObj<TmsPriceZoneCountry> responseObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsPriceZoneCountry>>(dataStr);
                    var detailLst = responseObj.GetJsonList();
                }
                catch (Exception ex)
                {
                    CommonHelper.Instance.ShowAlert(ex.Message);
                    CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
                }
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
