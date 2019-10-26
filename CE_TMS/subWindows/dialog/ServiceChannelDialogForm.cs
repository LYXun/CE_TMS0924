using CES_TMS.MODEL;
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
        private List<TmsServiceChannel> list;

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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
