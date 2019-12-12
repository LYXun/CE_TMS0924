using CES_TMS.COMMON;
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
    public partial class FreightPriceSettingWeightTemplateDialogForm : Form
    {
        private object changeCountryName;
        private object bigZoneId;
        internal string mainForm;
        internal string zoneTemplateId;
        internal string priceTemplateId;
        private TmsZoneTemplate zoneTemplate;

        public FreightPriceSettingWeightTemplateDialogForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void AddRow()
        {
            int rowIndex = this.dataGridViewXMain.Rows.Add();
            this.dataGridViewXMain.Rows[rowIndex].Cells[1].Value = changeCountryName;
            this.dataGridViewXMain.Rows[rowIndex].Cells[2].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells[3].Value = "单价";
            this.dataGridViewXMain.Rows[rowIndex].Cells[4].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells[5].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells[6].Value = "";
            this.dataGridViewXMain.Rows[rowIndex].Cells["ZoneID"].Value = this.bigZoneId;
        }

        private void FreightPriceSettingWeightTemplateDialogForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewXMain.DataError += DataGridViewXMain_DataError;
            this.dataGridViewXMain.RowStateChanged += DataGridViewXMain_RowStateChanged;
            this.dataGridViewXLeft.RowStateChanged += DataGridViewXMain_RowStateChanged;
        }

        private void DataGridViewXMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DataGridViewXMain_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClosing_Click(object sender, EventArgs e)
        {
            //弹出警告框 
            if (DialogResult.OK == MessageBox.Show(string.Format("当前价格表没有设置完成，是否要退出？"), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                //关闭所有关联窗体
                CommonHelper.Instance.ClearPriceTemplateObjectsCache();
                string[] formAry = { "FreightPriceSettingWeightTemplateDialogForm", "FreightPriceSettingPriceDialogForm" };
                UIHelper.Instance.CloseForm(formAry);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var rowCnt = this.dataGridViewXMain.Rows.Count;
            if (rowCnt < 1)
            {
                CommonHelper.Instance.ShowToast(this, "请输入重量模板信息");
                return;
            }
            try
            {
                string name = "";
                string title = "";
                string type = "";
                string begin = "";
                string end = "";
                string weight = "";
                decimal result = 0;

                //单元格数据验证
                for (int i = 0; i < rowCnt; i++)
                {
                    name = this.dataGridViewXMain.Rows[i].Cells[1].Value.ToString();
                    title = this.dataGridViewXMain.Rows[i].Cells[2].Value.ToString();
                    type = this.dataGridViewXMain.Rows[i].Cells[3].Value.ToString();
                    begin = this.dataGridViewXMain.Rows[i].Cells[4].Value.ToString();
                    end = this.dataGridViewXMain.Rows[i].Cells[5].Value.ToString();
                    weight = this.dataGridViewXMain.Rows[i].Cells[6].Value.ToString();

                    if (name.Length < 1 || title.Length < 1 || type.Length < 1 || begin.Length < 1 || end.Length < 1 || weight.Length < 1)
                    {
                        CommonHelper.Instance.ShowToast(this, "不能为空" + i);
                        return;
                    }
                    if (!decimal.TryParse(begin, out result))
                    {
                        CommonHelper.Instance.ShowToast(this, "begin格式不正确" + i);
                        return;
                    }
                    if (!decimal.TryParse(end, out result))
                    {
                        CommonHelper.Instance.ShowToast(this, "end格式不正确" + i);
                        return;
                    }
                    if (!decimal.TryParse(weight, out result))
                    {
                        CommonHelper.Instance.ShowToast(this, "weight格式不正确" + i);
                        return;
                    }
                }
                this.dataGridViewXMain.EndEdit();
                zoneTemplate.ZoneWeigthTemplateName = "";
                this.list = zoneTemplate.ZoneWeightList;
                int allCnt = list.Count;
                string id = string.Empty;
                string costType = "1";
                string zoneId = "";
                string zoneName = "";
                string guid = "";
                for (int i = 0; i < rowCnt; i++)
                {
                    costType = dataGridViewXMain.Rows[i].Cells[3].Value.ToString();
                    costType = costType.Equals("单价") ? "1" : "2";

                    guid = Guid.NewGuid().ToString();
                    zoneName = dataGridViewXMain.Rows[i].Cells[1].Value.ToString();
                    var objs = zoneTemplate.AllZoneCountryList.Find(o => o.BigZoneName.Equals(zoneName));
                    if (objs != null)
                    {
                        zoneId = objs.BigZoneID;
                    }

                    if (dataGridViewXMain.Rows[i].Cells["ID"].Value == null)
                    {
                        this.list.Add(new TmsPriceWeightZone()
                        {
                            Id = guid,
                            WeightZoneName = dataGridViewXMain.Rows[i].Cells[2].Value.ToString(),
                            CostType = costType,
                            WeightBegin = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[4].Value.ToString()),
                            WeightEnd = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[5].Value.ToString()),
                            UnitWeight = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[6].Value.ToString()),
                            HostWeightId = zoneTemplate.ZoneWeigthTemplateID,
                            HOST_BIG_ZONE_ID = zoneId,//dataGridViewXMain.Rows[i].Cells["ZoneID"].Value.ToString(),
                            HOST_BIG_ZONE_NAME = zoneName,
                            OrderNo = (allCnt + i + 1)
                        });
                        dataGridViewXMain.Rows[i].Cells["ID"].Value = guid;
                    }
                    else
                    {
                        id = dataGridViewXMain.Rows[i].Cells["ID"].Value.ToString();
                        var obj = this.list.Find(c => c.Id.Equals(id));
                        if (obj == null)
                        {
                            this.list.Add(new TmsPriceWeightZone()
                            {
                                Id = guid,
                                WeightZoneName = zoneName,
                                CostType = costType,
                                WeightBegin = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[4].Value.ToString()),
                                WeightEnd = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[5].Value.ToString()),
                                UnitWeight = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[6].Value.ToString()),
                                HostWeightId = zoneTemplate.ZoneWeigthTemplateID,
                                HOST_BIG_ZONE_ID = zoneId,//dataGridViewXMain.Rows[i].Cells["ZoneID"].Value.ToString(),
                                HOST_BIG_ZONE_NAME = dataGridViewXMain.Rows[i].Cells[1].Value.ToString(),
                                OrderNo = (allCnt + i + 1)
                            });
                        }
                        else
                        {
                            obj.WeightZoneName = dataGridViewXMain.Rows[i].Cells[2].Value.ToString();
                            obj.CostType = costType;
                            obj.WeightBegin = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[4].Value.ToString());
                            obj.WeightEnd = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[5].Value.ToString());
                            obj.UnitWeight = Convert.ToDecimal(dataGridViewXMain.Rows[i].Cells[6].Value.ToString());
                        }
                    }
                }
                //同名重量段信息筛选验证
                //var weightLst = list.GroupBy(x => x.WeightZoneName).Where(x => x.Count() > 1).ToList();
                //if (weightLst.Count > 0) {
                //    CommonHelper.Instance.ShowToast(this, "重量模板标题不能重复添加");
                //    return;
                //}
                string test = JsonConvert.SerializeObject(this.list);
                zoneTemplate.ZoneWeightList = this.list;
                CachHelper.Instance.Add("zone", zoneTemplate);
                Form frm = Application.OpenForms["FreightPriceSettingPriceDialogForm"];
                if (frm != null)
                {
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    FreightPriceSettingPriceDialogForm priceDialog = new FreightPriceSettingPriceDialogForm();
                    priceDialog.mainForm = "FreightPriceSettingWeightTemplateDialogForm";
                    priceDialog.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                CommonHelper.Instance.ShowAlert(ex.Message);
                CommonHelper.Instance.LogHelperInfo(LogLevel.Error, ex.Message);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms[this.mainForm];
            if (frm != null)
            {
                frm.Show();
                this.Hide();
            }
        }
    }
}
