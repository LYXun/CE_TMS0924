using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.COMMON
{
    public class CachHelper
    {
        public static CachHelper instance =null;
        private static object lockHelper = new object();
        private SortedDictionary<string,object> dic = new SortedDictionary<string, object>();

        private CachHelper() { }
        public static CachHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(lockHelper)
                    {
                        if(instance == null)
                        {
                            instance = new CachHelper();
                        }
                    }
                }
                return instance;
            }
        }

        public object GetData(string key)
        {
            if (!dic.ContainsKey(key))
                return null;
            return dic[key];
        }
    }
}
