using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CES_TMS.MODEL;
using DevComponents.DotNetBar.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;

namespace CES_TMS.COMMON
{
    public class UIHelper
    {
        private static UIHelper instance = null;
        private static object lockHelper = new object();

        public static UIHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new UIHelper();
                        }
                    }
                }
                return instance;
            }
        }

        public List<TmsServiceProduct> GetProductList(string channelCode)
        {
            string url = ServicesAPIHelper.Instance.ServiceProductQueryListUrl;
            dynamic searchObj = new JObject();
            searchObj.keyWord = "";
            searchObj.status = "";
            searchObj.pageIndex = 1;
            searchObj.pageSize = 0;
            var paramsStr = searchObj.ToString();
            var dataStr = COMMON.NetHelper.HttpApi(url, paramsStr, "post");
            TmsReturnBaseObj<TmsServiceProduct> parentObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsServiceProduct>>(dataStr);
            List<TmsServiceProduct> list = parentObj.GetJsonList();
            if(string.IsNullOrEmpty(channelCode) || channelCode.Length < 1)
            {
                return list;
            }
            list = list.FindAll(i => i.HostChannelCode.Equals(channelCode));
            return list;
        }

        #region 获取销售产品
        public void GetProductCombox(ComboBoxEx comboBoxExProduct, bool isSelected = true)
        {
            try
            {
                //获取销售产品
                string url = ServicesAPIHelper.Instance.ServiceProductQueryListUrl;
                dynamic searchObj = new JObject();
                searchObj.keyWord = "";
                searchObj.status = "";
                searchObj.pageSize = 0;
                searchObj.pageIndex = 1;
                var paramsStr = searchObj.ToString();
                var dataStr = COMMON.NetHelper.HttpApi(url, paramsStr, "post");
                TmsReturnBaseObj<TmsServiceProduct> parentObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<TmsServiceProduct>>(dataStr);
                List<TmsServiceProduct> list = parentObj.GetJsonList();
                BindComboxData(comboBoxExProduct, list, "PRODUCTFULLNAME", "PRODUCTCODE", isSelected);
            }
            catch (Exception ex)
            {
                CommonHelper.Instance.ShowAlert(ex.Message);
                CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
            }
        } 
        #endregion

        public void BindComboxData(ComboBoxEx comboBoxProduct, object plist, string filed, string value,bool isSelected = false)
        {
            comboBoxProduct.DataSource = plist;
            comboBoxProduct.ValueMember = value;
            comboBoxProduct.DisplayMember = filed;
            if (isSelected)
            {
                comboBoxProduct.SelectedIndex = -1;
            }
        }
    }
}
