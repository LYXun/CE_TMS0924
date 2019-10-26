using CES_TMS.COMMON;
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

namespace CES_TMS.subWindows.dialog.services
{
    public partial class AddServicesProviderDialogForm : Form
    {
        private TmsServiceProvider providerObj;
        private bool updateFlag;

        public delegate void RefreshDelegate();
        public event RefreshDelegate refreshEvent;

        public AddServicesProviderDialogForm()
        {
            InitializeComponent();
        }

        private void AddServicesProviderDialogForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            if (providerObj != null)
            {
                txtCode.Text = providerObj.ServiceCode;
                txtSName.Text = providerObj.ServiceShortName;
                txtFName.Text = providerObj.ServiceFullName;
                txtAddress.Text = providerObj.ServiceAddress;
                txtTel.Text = providerObj.ServiceTel;
                //绑定组织机构

                int status = 1;
                int.TryParse(providerObj.Status, out status);
                if (status == 1)
                {
                    radioButtonStatus.Checked = true;
                }
                else
                {
                    radioButtonStatus2.Checked = true;
                }
                updateFlag = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckAction())
            {
                return;
            }
        }

        private bool CheckAction()
        {
            string code = txtCode.Text.Trim();
            string sName = txtSName.Text.Trim();
            string fName = txtFName.Text.Trim();

            int codeLength = System.Text.Encoding.Default.GetBytes(code).Length;
            int sNameLength = System.Text.Encoding.Default.GetBytes(sName).Length;
            int fNameLength = System.Text.Encoding.Default.GetBytes(fName).Length;

            if (codeLength < 1)
            {
                CommonHelper.Instance.ShowToast(this, "服务商代码不能为空");
                return false;
            }
            if (codeLength > 10)
            {
                CommonHelper.Instance.ShowToast(this, "服务商代码长度不能大10个字符");
                return false;
            }
            if (sNameLength < 1)
            {
                CommonHelper.Instance.ShowToast(this, "服务商简称不能为空");
                return false;
            }
            if (sNameLength > 30)
            {
                CommonHelper.Instance.ShowToast(this, "服务商简称长度不能大30个字符");
                return false;
            }
            if (fNameLength < 1)
            {
                CommonHelper.Instance.ShowToast(this, "服务商全称不能为空");
                return false;
            }
            if (fNameLength > 200)
            {
                CommonHelper.Instance.ShowToast(this, "服务商全称长度不能大200个字符");
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
