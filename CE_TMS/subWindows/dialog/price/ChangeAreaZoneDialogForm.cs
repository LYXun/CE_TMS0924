using CES_TMS.COMMON;
using CES_TMS.MODEL;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.subWindows.dialog.price
{
    public partial class ChangeAreaZoneDialogForm : Form
    {
        public delegate void ChangeZone(TmsPriceZone obj);
        public event ChangeZone ChangeZoneEvent;

        public ChangeAreaZoneDialogForm()
        {
            InitializeComponent();
        }

        private void ChangeAreaZoneDialogForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewXMain.RowStateChanged += DataGridViewXMain_RowStateChanged;
            searchAction();
        }

        private void searchAction()
        {
            try
            {
                string url = ServicesAPIHelper.Instance.ZonePlanQueryListUrl;
                string paramsStr = GetSearchParams();
                var dataStr = COMMON.NetHelper.HttpApi(url, paramsStr, "post");
                TmsReturnBaseObj<TmsPriceZone> parentObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsPriceZone>>(dataStr);
                var list = parentObj.GetJsonList();
                if (list == null || list.Count < 1)
                {
                    CommonHelper.Instance.ShowToast(this, "没有记录行");
                }
                this.dataGridViewXMain.AutoGenerateColumns = false;
                this.dataGridViewXMain.DataSource = list;
            }
            catch (Exception ex)
            {
                ThreadPool.QueueUserWorkItem(a =>
                {
                    CommonHelper.Instance.ShowAlert(ex.Message);
                    CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
                });
            }
        }

        private string GetSearchParams()
        {
            dynamic searchObj = new JObject();
            searchObj.keyWord = "";
            searchObj.pageSize = "0";
            searchObj.pageIndex = "1";
            return searchObj.ToString();
        }

        private void DataGridViewXMain_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dataGridViewXMain_DoubleClick(object sender, EventArgs e)
        {
            Commit();
        }

        private void Commit()
        {
            string remarkStr = string.Empty;
            string nameStr = string.Empty;
            string id = string.Empty;
            TmsPriceZone zoneObj;

            if (this.dataGridViewXMain.Rows.Count > 0)
            {
                zoneObj = new TmsPriceZone();
                zoneObj.Remark = dataGridViewXMain.CurrentRow.Cells["Remark"].Value.ToString();
                zoneObj.ZoneName = dataGridViewXMain.CurrentRow.Cells["ZoneName"].Value.ToString();
                zoneObj.Id = dataGridViewXMain.CurrentRow.Cells["ID"].Value.ToString();
                zoneObj.Status = ((int)ZoneStatus.发布).ToString();
                ChangeZoneEvent?.Invoke(zoneObj);
            }
            this.Close();
        }
    }
}
