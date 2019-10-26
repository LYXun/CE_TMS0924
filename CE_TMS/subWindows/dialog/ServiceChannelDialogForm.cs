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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.subWindows.dialog
{
    public partial class ServiceChannelDialogForm : Form
    {
        private List<TmsServiceChannel> list = null;
        private dynamic servicePrivoderCode = "";

        public ServiceChannelDialogForm()
        {
            InitializeComponent();
        }
        public delegate void ChangeDiaDelegate(string serviceChannel, string serviceChannelName);
        public event ChangeDiaDelegate ChangeChannelEvent;//事件  服务渠道

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchChannel(this.txtServiceChannel.Text.ToUpper());
        }

        private void searchChannel(string code)
        {
            if(this.list == null || this.list.Count <1)
            {
                return;
            }
            List<TmsServiceChannel> findList = this.list.FindAll(i => i.ChannelCode.IndexOf(code) >= 0 || i.ChannelShortName.IndexOf(code) >= 0);
            this.dataGridServiceChannel.DataSource = findList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceChannelDialogForm_Load(object sender, EventArgs e)
        {
            this.dataGridServiceChannel.RowStateChanged += DataGridServiceChannel_RowStateChanged;
            searchAction();
        }

        private void searchAction()
        {
            try
            {
                string url = ServicesAPIHelper.Instance.ServiceChannelQueryListUrl;
                string paramsStr = GetServiceChannelParams();
                var dataStr = NetHelper.HttpApi(url, paramsStr, "post");
                TmsReturnBaseObj<TmsServiceChannel> parentObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsServiceChannel>>(dataStr);
                this.list = parentObj.GetJsonList();
                this.dataGridServiceChannel.AutoGenerateColumns = false;
                this.dataGridServiceChannel.DataSource = list;
            }
            catch (Exception ex)
            {
                CommonHelper.Instance.ShowAlert(ex.Message);
                CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
            }
        }

        private string GetServiceChannelParams()
        {
            dynamic searchObj = new JObject();
            searchObj.keyWord = "";     /*关键字，模糊搜素渠道简称，供应商全称，供应商代码*/
            searchObj.servicePrivoderCode = servicePrivoderCode;    /*  所属供应商id*/
            searchObj.status = "";    /*渠道状态，1：生效，2：失效，3：不判别*/
            searchObj.pageSize = 0;     /*分页大小，为0 时不分页*/
            searchObj.pageIndex = 1;     /*分页页码，从1开始*/
            return searchObj.ToString();
        }

        private void DataGridServiceChannel_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string codeStr = string.Empty;
            string nameStr = string.Empty;

            if (this.dataGridServiceChannel.Rows.Count > 0)
            {
                codeStr = dataGridServiceChannel.CurrentRow.Cells[0].Value.ToString();  //获取指定列第一个值
                nameStr = dataGridServiceChannel.CurrentRow.Cells[1].Value.ToString();  //获取指定列第二个值
            }
            ChangeChannelEvent?.Invoke(codeStr, nameStr);
            this.Close();
        }

    }   

}
