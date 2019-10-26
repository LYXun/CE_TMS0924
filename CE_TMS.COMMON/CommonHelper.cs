using CES_TMS.MODEL;
using DevComponents.DotNetBar;
using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_TMS.COMMON
{
    public class CommonHelper
    {
        private static CommonHelper instance = null;
        private static object lockHelper = new object();

        public static CommonHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (lockHelper)
                    {
                        if(instance == null)
                        {
                            instance = new CommonHelper();
                        }
                    }
                }
                return instance;
            }
        }

        public string GetUserName()
        {
            var userCacheObj = CachHelper.Instance.GetData("user") as TmsCustomer;
            if(userCacheObj == null || string.IsNullOrEmpty(userCacheObj.CreateOpName))
            {
                return "";
            }
            return userCacheObj.CreateOpName;
        }

        public void ShowAlert(string msg)
        {
            TaskDialog.Show("TMS管理系统",eTaskDialogIcon.Exclamation,msg,"",eTaskDialogButton.Ok,eTaskDialogBackgroundColor.Red);
        }

        public void LogHelperInfo(LogLevel level, string info)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Log(level,info);
        }

        public void ShowToast(Control control, string msg,int millSec = 2500)
        {
            ToastNotification.ToastBackColor = Color.BurlyWood;
            ToastNotification.ToastFont = new Font(new FontFamily("宋体"), 18);
            ToastNotification.ToastForeColor = Color.Black;
            ToastNotification.Show(control, msg, null, millSec, eToastGlowColor.None, eToastPosition.MiddleCenter);
        }

    }
}
