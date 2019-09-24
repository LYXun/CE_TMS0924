using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CE_TMS.COMMON
{
    public class ServicesAPIHelper
    {
        public static ServicesAPIHelper instance = null;
        private static object lockHelper = new object();
        public string IdpBaseUrl = ConfigurationManager.AppSettings["IdpBaseUrl"].ToString();

        public static ServicesAPIHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(lockHelper)
                    {
                        if(instance == null)
                        {
                            instance = new ServicesAPIHelper();

                        }
                    }
                }
                return instance;
            }
           
        }

        #region  LoginUrl
        public string LoginUrl
        {
            get
            {
                return IdpBaseUrl + ConfigurationManager.AppSettings["LoginUrl"].ToString();
            }
        }
        #endregion

    }
}
