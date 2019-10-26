using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.MODEL
{
    public class TmsReturnObj<T>
    {
        public object Code { get; set; }
        public string Msg { get; set; }
        public string Obj_Count { get; set; }
        public string Obj_Json { get; set; }
        public List<T> ListItem { get; set; }
    }
}
