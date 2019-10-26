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

namespace CES_TMS.subWindows.dialog.price
{
    public partial class FreightPriceSettingCostAreaDialogForm : Form
    {
        private bool isUpdate;
        private TmsPriceZone zoneHead;
        private List<TmsPriceZoneCountry> zoneCountryList;
        public delegate void refreshDelegate(); //委托
        private event refreshDelegate refreshEvent;//事件

        public FreightPriceSettingCostAreaDialogForm()
        {
            InitializeComponent();
        }

        #region 窗体加载
        private void FreightPriceSettingCostAreaDialogForm_Load(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region 保存
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAreaName.Text) || txtAreaName.Text.Length < 1)
                {
                    CommonHelper.Instance.ShowToast(this, "请填写分区方案名称");
                    return;
                }
                int rowCnt = this.dataGridViewXMain.Rows.Count;
                if (rowCnt < 1)
                {
                    CommonHelper.Instance.ShowToast(this, "请添加国家信息");
                    return;
                }

                var list = this.zoneCountryList.FindAll(o => o.CountryCode.Equals("99") || o.CountryName.Equals("99")).ToList();
                if (list.Count > 0)
                {
                    CommonHelper.Instance.ShowToast(this, "存在不合法的国家代码，请修改");
                    return;
                }


                zoneHead.ZoneName = txtAreaName.Text;
                zoneHead.Remark = txtRemark.Text;
                if (checkBoxSave.Checked)
                {
                    zoneHead.Status = ((int)ZoneStatus.发布).ToString();
                }
                //保存
                string url = ServicesAPIHelper.Instance.ZonePlanAddPlanUrl;
                if (isUpdate)
                {
                    url = ServicesAPIHelper.Instance.ZonePlanUpdatePlanUrl;
                }

                dynamic planObj = new JObject();
                planObj.plan = JsonConvert.SerializeObject(zoneHead);
                planObj.planDetail = JsonConvert.SerializeObject(zoneCountryList);
                string paramsStr = planObj.ToString();
                CommonHelper.Instance.LogHelperInfo(LogLevel.Info, string.Format("{0}-{1}", url, paramsStr));
                var dataStr = COMMON.NetHelper.HttpApi(url, paramsStr, "post");
                TmsReturnBaseObj<object> responseObj = JsonConvert.DeserializeObject<TmsReturnBaseObj<object>>(dataStr);

                if (responseObj == null)
                {
                    CommonHelper.Instance.ShowToast(this, "接口返回数据为空");
                    return;
                }
                if (!responseObj.UpdateObj.Code.Equals("0000"))
                {
                    CommonHelper.Instance.ShowToast(this, responseObj.UpdateObj.Msg);
                    return;
                }
                refreshEvent?.Invoke();

                this.Close();
            } 
            catch (Exception ex)
            {
                CommonHelper.Instance.ShowAlert(ex.InnerException.ToString());
                CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
            }
        } 
        #endregion

        #region 自定义分区
        private void btnAddZone_Click(object sender, EventArgs e)
        {

        } 
        #endregion
    }


}
