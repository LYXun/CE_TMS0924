using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.MODEL
{
    public class CacheHelper
    {
        private static CacheHelper instance = null;
        private static object lockHelper = new object();
        private SortedDictionary<string,object> dic = new SortedDictionary<string, object>();

        private CacheHelper()
        {

        }

        public static CacheHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (lockHelper)
                    {
                        if(instance == null)
                        {
                            instance = new CacheHelper();
                        }
                    }
                }
                return instance;
            }
        }

        public void Add(string key,object value)
        {
            if(dic.ContainsKey(key))
            {
                dic.Remove(key);
                dic.Add(key,value);
            }
            else
            {
                dic.Add(key,value);
            }
        }
    }
}
