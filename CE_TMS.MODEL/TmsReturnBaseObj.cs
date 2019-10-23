using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.MODEL
{
    public class TmsReturnBaseObj<T>
    {

        public string Entity { get; set; }
        public TmsReturnObj<T> ReturnObj { get; set; }

        public TmsReturnObj<T> UpdateObj{
            get
            {
                return JsonConvert.DeserializeObject<TmsReturnObj<T>>(this.Entity);
            }
        }

        public List<T> GetJsonList()
        {
            if (!string.IsNullOrEmpty(this.Entity))
            {
                this.ReturnObj = JsonConvert.DeserializeObject<TmsReturnObj<T>>(this.Entity);
                if (string.IsNullOrEmpty(this.ReturnObj.Obj_Json))
                {
                    return null;
                }
                string objJson = this.ReturnObj.Obj_Json.Replace("{}", "");
                if (!string.IsNullOrEmpty(objJson))
                {
                    this.ReturnObj.ListItem = JsonConvert.DeserializeObject<List<T>>(objJson);
                    return this.ReturnObj.ListItem;
                }
                return null;
            }
            return null;
        }
    }
}
