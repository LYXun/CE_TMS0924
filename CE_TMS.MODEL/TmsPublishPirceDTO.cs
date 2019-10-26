using CES_TMS.COMMON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    public class TmsPublishPirceDTO:TmsObject
    {
        public string HostChannelId { get; set; }

        public string HostChannelName { get; set; }

        public string HostProductId { get; set; }

        public string HostProductName { get; set; }

        public string GoodsType { get; set; }

        [JsonIgnore]
        public string GoodsTypeName
        {
            get
            {
                int t = 1;
                int.TryParse(GoodsType, out t);
                switch (t)
                {
                    case 1:
                        return GoodsTypeNames.袋子.ToString();
                    case 2:
                        return GoodsTypeNames.文件.ToString();
                    case 3:
                        return GoodsTypeNames.包裹.ToString();
                }
                return GoodsTypeNames.袋子.ToString();
            }
        }

        public string PriceName { get; set; }

        public string Currency { get; set; }

        public DateTime? EffectBegin { get; set; }

        public DateTime? EffectEnd { get; set; }

        public string FeeId { get; set; }

        public string FeeName { get; set; }

        public string PublishCode { get; set; }

        public string HostZoneId { get; set; }

        public string HostWeightId { get; set; }

        public string HostZoneName { get; set; }

        public string HostWeightName { get; set; }

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
