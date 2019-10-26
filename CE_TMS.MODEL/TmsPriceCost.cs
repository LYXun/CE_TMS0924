using CES_TMS.COMMON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    /// <summary>
    /// 成本价管理
    /// </summary>
    public class TmsPriceCost : TmsObject
    {
        /// <summary>
        /// 所属渠道id
        /// </summary>
        public string HostChannelId { get; set; }
        /// <summary>
        /// 所属渠道名
        /// </summary>
        public string HostChannelName { get; set; }
        /// <summary>
        /// 所属产品id
        /// </summary>
        public string HostProductId { get; set; }
        /// <summary>
        /// 所属产品名称
        /// </summary>
        public string HostProductName { get; set; }
        /// <summary>
        /// 货物类型：包裹，文件，其他
        /// </summary>
        public string GoodsType { get; set; }
        /// <summary>
        /// 价格方案名
        /// </summary>
        public string PriceName { get; set; }
        /// <summary>
        /// 币制
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 起效时间
        /// </summary>
        public DateTime? EffectBegin { get; set; }
        /// <summary>
        /// 失效时间
        /// </summary>
        public DateTime? EffectEnd { get; set; }
        /// <summary>
        /// 公布价 id
        /// </summary>
        public string PublishNameId { get; set; }
        /// <summary>
        /// 公布价 名称
        /// </summary>
        public string PublishNameName { get; set; }
        /// <summary>
        /// 付费方式：1，预付；2，其他
        /// </summary>
        public string PayType { get; set; }

        public string HostZoneId { get; set; }

        public string HostWeightId { get; set; }

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

        /// <summary>
        /// 业务归属组织id
        /// </summary>
        public string HostOrgId { get; set; }

        /// <summary>
        /// 业务归属组织名
        /// </summary>
        public string HostOrgName { get; set; }

    }
}
