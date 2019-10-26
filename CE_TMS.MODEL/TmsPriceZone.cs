using CES_TMS.COMMON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    public class TmsPriceZone
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 分区方案名
        /// </summary>
        public string ZoneName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 成本价id
        /// </summary>
        public string HostCostId { get; set; }

        public string Status { get; set; }

        [JsonIgnore]
        public string StatusName
        {
            get
            {
                int flag = 1;
                int.TryParse(Status, out flag);
                switch (flag)
                {
                    case 1:
                        return ZoneStatus.草稿.ToString();
                    case 2:
                        return ZoneStatus.发布.ToString();
                    case 3:
                        return ZoneStatus.作废.ToString();
                }

                return ZoneStatus.草稿.ToString();
            }
        }
    }
}
