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

    }
}
