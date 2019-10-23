using CE_TMS.COMMON;
using CE_TMS.MODEL;
using Newtonsoft.Json;
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

namespace CE_TMS.subWindows.servicesManager
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
                string url = COMMON.ServicesAPIHelper.Instance.ServiceProviderQueryListUrl;
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
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }
    }
}
