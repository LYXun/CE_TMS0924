using DevComponents.DotNetBar;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.COMMON
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

        public void ShowAlert(string msg)
        {
            TaskDialog.Show("慧运TMS管理系统",eTaskDialogIcon.Exclamation,msg,"",eTaskDialogButton.Ok,eTaskDialogBackgroundColor.Red);
        }

        public void ShowAlert(object msg)
        {
            throw new NotImplementedException();
        }

        public void LogHelperInfo(LogLevel level, string info)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Log(level,info);
        }
    }
}
