using CES_TMS.COMMON;
using CES_TMS.MODEL;
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

namespace CES_TMS.subWindows.dialog.price
{
    public partial class AddCostDiaLogForm : Form
    {
        private TmsPriceCost costObj;
        private TmsPublishPirceDTO publicObjDto;
        private string hostZoneId;

        public AddCostDiaLogForm()
        {
            InitializeComponent();
        }

        private void AddCostDiaLogForm_Load(object sender, EventArgs e)
        {

        }

        #region 关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region 下一步
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtPriceName.Text.Length < 1)
            {
                CommonHelper.Instance.ShowToast(this, "成本价名称不能为空");
                return;
            }
            if (txtPublishName.Text.Length < 1)
            {
                CommonHelper.Instance.ShowToast(this, "请选择公布价方案");
                return;
            }
            if (txtZoneName.Text.Length < 1)
            {
                CommonHelper.Instance.ShowToast(this, "请选分区方案");
                return;
            }
            try
            {
                costObj.PriceName = txtPriceName.Text;
                costObj.EffectBegin = DateTime.Parse(this.dateTimeInputStart.Text).ToLocalTime();
                costObj.EffectEnd = DateTime.Parse(this.dateTimeInputEnd.Text).ToLocalTime();

                if (comboBoxExProductType.SelectedItem != null)
                {
                    costObj.GoodsType = (comboBoxExProductType.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
                }
                if (cBoxRmbType.SelectedItem != null)
                {
                    costObj.Currency = (cBoxRmbType.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
                }
                if (comboBoxExPayType.SelectedItem != null)
                {
                    costObj.PayType = (comboBoxExPayType.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
                }
                //if (comboBoxExPublish.SelectedItem != null) //公布价
                //{
                //    var publish = comboBoxExPublish.SelectedItem as TmsPricePublish;
                //    costObj.PublishNameName = publish.PriceName;
                //    costObj.PublishNameId = publish.Id;
                //}

                costObj.HostZoneId = hostZoneId;
                if (publicObjDto != null)
                {
                    costObj.HostProductId = publicObjDto.HostProductId;
                    costObj.HostProductName = publicObjDto.HostProductName;
                    costObj.HostChannelId = publicObjDto.HostChannelId;
                    costObj.HostChannelName = publicObjDto.HostChannelName;
                    costObj.PublishNameId = publicObjDto.Id;
                    costObj.PublishNameName = publicObjDto.PriceName;
                }

                string objStr = JsonConvert.SerializeObject(costObj);
                Dictionary<string, string> priceDic = new Dictionary<string, string>();
                priceDic.Add(((int)PriceType.成本).ToString(), objStr);
                CachHelper.Instance.Add("priceServicesKey", PriceServicesKey.CostPrice.ToString());
                CachHelper.Instance.Add("priceDic", priceDic);
                CachHelper.Instance.Add("costId", costObj.HostProductId);

                Form frm = Application.OpenForms["FreightPriceSettingWeightTemplateDialogForm"];
                if (frm == null)
                {
                    FreightPriceSettingWeightTemplateDialogForm weightDialog = new FreightPriceSettingWeightTemplateDialogForm();
                    weightDialog.mainForm = "AddCostDiaLogForm";
                    weightDialog.zoneTemplateId = costObj.HostZoneId;
                    weightDialog.priceTemplateId = costObj.Id;
                    weightDialog.Show();
                    this.Hide();
                }
                else
                {
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                CommonHelper.Instance.ShowAlert(ex.Message);
                CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.InnerException.ToString());
            }
        } 
        #endregion

        #region 分区方案名称
        private void btnZone_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region 公布价信息
        private void btnPublish_Click(object sender, EventArgs e)
        {

        } 
        #endregion
    }
}
