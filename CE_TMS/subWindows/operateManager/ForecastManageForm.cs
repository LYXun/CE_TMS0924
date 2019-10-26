using CES_TMS.subWindows.dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.subWindows.operateManager
{
    public partial class ForecastManageForm : Form
    {

        public ForecastManageForm()
        {
            InitializeComponent();
        }

        private void ForecastManageForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMain_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {

        }
        //运单号查询
        private void btnImportOrderNo_Click(object sender, EventArgs e)
        {
            using (ImportOrderNumberDialogForm importOrderDialogForm = new ImportOrderNumberDialogForm())
            {
                importOrderDialogForm.ChangeBusinessEvent += ImportOrderDialogForm_ChangeBusinessEvent;
                importOrderDialogForm.ShowDialog(this);
            }
        }

        private void ImportOrderDialogForm_ChangeBusinessEvent(string businessNo)
        {
            this.txtWayBillNO.Text = businessNo;
        }
        //服务商查询
        private void btnServerProvider_Click(object sender, EventArgs e)
        {
            using (ServiceProviderDialogForm providerDialogForm = new ServiceProviderDialogForm())
            {
                providerDialogForm.ChangeProviderEvent += ProviderDialogForm_ChangeProviderEvent;
                providerDialogForm.ShowDialog();
            }
        }

        private void ProviderDialogForm_ChangeProviderEvent(string providerCode, string providerName)
        {
            this.txtServiceProvider.Text = providerCode;
        }
        //服务商渠道
        private void btnServiceChannel_Click(object sender, EventArgs e)
        {
            using (ServiceChannelDialogForm channelDialogForm = new ServiceChannelDialogForm())
            {
                channelDialogForm.ChangeChannelEvent += ChannelDialogForm_ChangeChannelEvent;
                channelDialogForm.ShowDialog();
            }
        }

        private void ChannelDialogForm_ChangeChannelEvent(string serviceChannel, string serviceChannelName)
        {
            this.txtServiceChannel.Text = serviceChannel;
        }
    }
}
