﻿using CE_TMS.COMMON;
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

namespace CE_TMS
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

        private void setTabShow(string tabName, string sfrmName,string sfrmRoot= "CE_TMS.subWindows.operateManager.")
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
            setTabShow("用户管理", "UserManagerForm", "CE_TMS.subWindows.userManager.");
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            setTabShow("用户类别", "UserCategoryManagerForm", "CE_TMS.subWindows.userManager.");
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
    }
}