using CES_TMS.COMMON;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS
{
    public partial class MainForm : Office2007Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setTabShow("预报管理", "ForecastManageForm");
            string userName = CommonHelper.Instance.GetUserName();
            if(!string.IsNullOrEmpty(userName))
            {
                toolStripStatusLabel1.Text = "当前登录用户:" + userName;
            }
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            setTabShow("预报管理", "ForecastManageForm");
        }

        private void setTabShow(string tabName, string sfrmName,string sfrmRoot= "CES_TMS.subWindows.operateManager.")
        {
            bool isOpen = false;
            foreach(SuperTabItem item in superTabControlMain.Tabs)
            {
                if(item.Name == tabName)
                {
                    superTabControlMain.SelectedTab = item;
                    isOpen = true;
                    break;
                }
            }
            if(!isOpen)
            {
                //反射取得子窗体对象
                object obj = Assembly.GetExecutingAssembly().CreateInstance(sfrmRoot + sfrmName,false);
                Form form = (Form)obj;
                form.TopLevel = false;
                form.Visible = true;
                form.Dock = DockStyle.Fill;
                SuperTabItem item = superTabControlMain.CreateTab(tabName);
                item.Text = tabName;
                if (item.Name.Equals("预报管理"))
                    item.CloseButtonVisible = true;
                item.AttachedControl.Controls.Add(form);
                superTabControlMain.SelectedTab = item;
            }
        }

        private void btnWayBill_Click(object sender, EventArgs e)
        {
            setTabShow("运单管理","WayBillSearchForm");
        }

        #region 用户管理
        private void buttonItem8_Click(object sender, EventArgs e)
        {
            setTabShow("用户管理", "UserManagerForm", "CES_TMS.subWindows.userManager.");
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            setTabShow("用户类别", "UserCategoryManagerForm", "CES_TMS.subWindows.userManager.");
        }
        #endregion

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            setTabShow("收款管理", "CollectManagerForm", "CES_TMS.subWindows.financeManager.collect.");
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            setTabShow("上家对账单", "CollectBillForm", "CES_TMS.subWindows.financeManager.collect.");
        }

        #region 服务商管理
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            setTabShow("服务商管理", "ServicesProviderForm", "CES_TMS.subWindows.servicesManager.");
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            setTabShow("渠道管理", "ServicesChannelForm", "CES_TMS.subWindows.servicesManager.");
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            setTabShow("产品管理", "ServicesProductForm", "CES_TMS.subWindows.servicesManager.");
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //分区管理
        private void buttonItem14_Click(object sender, EventArgs e)
        {
            setTabShow("分区管理", "ZoneManageForm", "CES_TMS.subWindows.priceManager.");
        }

        //公布价管理
        private void buttonItem15_Click(object sender, EventArgs e)
        {
            setTabShow("公布价格管理", "PublicPriceForm", "CES_TMS.subWindows.priceManager.");
        }

        //成本价管理
        private void buttonItem16_Click(object sender, EventArgs e)
        {
            setTabShow("成本价管理", "CostPriceForm", "CES_TMS.subWindows.priceManager.");
        }

        //销售价管理
        private void buttonItem17_Click(object sender, EventArgs e)
        {
            setTabShow("销售价格管理", "SalePriceForm", "CES_TMS.subWindows.priceManager.");
        }

        //类别价管理
        private void buttonItem18_Click(object sender, EventArgs e)
        {
            setTabShow("类别价管理", "KindPriceForm", "CES_TMS.subWindows.priceManager.");
        }

        //客户协议价维护
        private void buttonItem19_Click(object sender, EventArgs e)
        {
            setTabShow("客户协议价格维护", "CustomerAgreedPriceForm", "CES_TMS.subWindows.priceManager.");
        }

        //价格试算
        private void buttonItem21_Click(object sender, EventArgs e)
        {
            setTabShow("价格试算", "CalePriceForm", "CES_TMS.subWindows.priceManager.");
        }

        //客户折扣价管理
        private void buttonItem20_Click(object sender, EventArgs e)
        {
            setTabShow("客户折扣价格管理", "CustomerDiscountPriceForm", "CES_TMS.subWindows.priceManager.");
        }

        //杂费价管理
        private void buttonItem22_Click(object sender, EventArgs e)
        {
            setTabShow("杂费价管理", "IncidentalPriceForm", "CES_TMS.subWindows.priceManager.");
        }
    }
}
