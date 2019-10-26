using CES_TMS.COMMON;
using CES_TMS.MODEL;
using CES_TMS.subWindows.dialog.services;
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

namespace CES_TMS.subWindows.servicesManager
{
    public partial class ServicesProviderForm : Form
    {
        private List<TmsServiceProvider> list = null;

        public ServicesProviderForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            searchAction();
        }

        private void searchAction()
        {
            try
            {
                string url = ServicesAPIHelper.Instance.ServiceProviderQueryListUrl;
                string paramsStr = GetServiceProoviderParams();
                var dataStr = NetHelper.HttpApi(url, paramsStr, "POST");
                TmsReturnBaseObj<TmsServiceProvider> parentObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsServiceProvider>>(dataStr);
                this.list = parentObj.GetJsonList();
                this.list = list.OrderByDescending(o => o.CreateTime).ToList();
                this.dataGridViewX1.AutoGenerateColumns = false;
                this.dataGridViewX1.DataSource = list;
            }
            catch (Exception ex)
            {
                CommonHelper.Instance.ShowAlert(ex.Message);
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Log(LogLevel.Error,ex.Message);
            }
        }

        private string GetServiceProoviderParams()
        {
            string status = "3";
            if (cmbStatus.SelectedItem != null)
            {
                status = (cmbStatus.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
            }

            dynamic searchObj = new JObject();
            searchObj.keyWord = txtServiceCode.Text.Trim();
            searchObj.orgId = "";
            searchObj.status = status;
            searchObj.pageSize = 0;
            searchObj.pageIndex = 1;
            return searchObj.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddServicesProviderDialogForm add = new AddServicesProviderDialogForm())
            {
                add.refreshEvent += searchAction;
                add.ShowDialog();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }
    }
}
