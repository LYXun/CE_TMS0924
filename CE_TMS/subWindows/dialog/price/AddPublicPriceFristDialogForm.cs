﻿using CES_TMS.COMMON;
using CES_TMS.MODEL;
using HYTMS.MODEL;
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
    public partial class AddPublicPriceFristDialogForm : Form
    {
        private string hostZoneId;
        private TmsPricePublish publishObj;

        public AddPublicPriceFristDialogForm()
        {
            InitializeComponent();
        }

        private void AddPublicPriceFristDialogForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(txtPriceName.Text.Length < 1)
            {
                CommonHelper.Instance.ShowToast(this, "公布价名称不能为空");
                return;
            }
            if (comboBoxExProduct.SelectedItem == null)
            {
                CommonHelper.Instance.ShowToast(this, "请选择产品");
                return;
            }
            if (txtZoneName.Text.Length < 1)
            {
                CommonHelper.Instance.ShowToast(this, "分区方案名称不能为空");
                return;
            }
            try
            {
                publishObj.PriceName = txtPriceName.Text;
                publishObj.EffectBegin = DateTime.Parse(this.dateTimeInputStart.Text).ToLocalTime(); //DateTime.Parse(this.dateTimeInputStart.Text).ToLocalTime();
                publishObj.EffectEnd = DateTime.Parse(this.dateTimeInputEnd.Text).ToLocalTime();
                if (comboBoxExProductType.SelectedItem != null)
                {
                    publishObj.GoodsType = (comboBoxExProductType.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
                }
                if (cBoxRmbType.SelectedItem != null)
                {
                    publishObj.Currency = (cBoxRmbType.SelectedItem as DevComponents.Editors.ComboItem).Value.ToString();
                }

                var product = comboBoxExProduct.SelectedItem as TmsServiceProduct;
                string productCode = product.ProductCode;
                string productName = product.ProductShortName;
                publishObj.HostProductId = productCode;
                publishObj.HostProductName = productName;
                publishObj.HostChannelId = product.HostChannelCode;
                publishObj.HostChannelName = product.HostChannelName;
                publishObj.HostZoneId = hostZoneId;

                string objStr = JsonConvert.SerializeObject(publishObj);
                Dictionary<string, string> priceDic = new Dictionary<string, string>();
                priceDic.Add(((int)PriceType.公布).ToString(), objStr);
                CachHelper.Instance.Add("priceDic", priceDic);
                CachHelper.Instance.Add("costId", productCode);
                CachHelper.Instance.Add("priceServicesKey", PriceServicesKey.PublishPrice.ToString());

                Form frm = Application.OpenForms["FreightPriceSettingWeightTemplateDialogForm"];
                if (frm == null)
                {
                    FreightPriceSettingWeightTemplateDialogForm weightDialog = new FreightPriceSettingWeightTemplateDialogForm();
                    weightDialog.mainForm = "AddPublicPriceFristDialogForm";
                    weightDialog.zoneTemplateId = publishObj.HostZoneId;
                    weightDialog.priceTemplateId = publishObj.Id;
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
                CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
            }
        }

        private void btnZone_Click(object sender, EventArgs e)
        {

        }
    }
}
