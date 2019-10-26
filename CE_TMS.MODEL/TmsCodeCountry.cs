using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    public class TmsCodeCountry
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 国家2字代码
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// 国家中文名
        /// </summary>
        public string CountryNameCn { get; set; }
        /// <summary>
        /// 国家英文名
        /// </summary>
        public string CountryNameEn { get; set; }
        /// <summary>
        /// 海关代码
        /// </summary>
        public string CustomsCode { get; set; }
        /// <summary>
        /// 商检代码
        /// </summary>
        public string CiqCode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        [JsonIgnore]
        /// <summary>
        /// 序列号
        /// </summary>
        public int SeqNo { get; set; }
    }
}
