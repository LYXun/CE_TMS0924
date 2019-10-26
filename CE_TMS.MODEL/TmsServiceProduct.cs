using CES_TMS.COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    /// <summary>
    /// 销售产品
    /// </summary>
    public class TmsServiceProduct:TmsObject
    {
        public string ProductCode { get; set; }

        public string ProductShortName { get; set; }

        public string ProductFullName { get; set; }

        public string ProductAlisa { get; set; }

        public string HostChannelCode { get; set; }

        public string HostChannelName { get; set; }

        public int? MinDay { get; set; }

        public int? MaxDay { get; set; }

        public string Status { get; set; }

        public string StatusName
        {
            get
            {
                int s = 0;
                int.TryParse(Status, out s);
                if ((int)ServicesStatus.生效 == s)
                {
                    return ServicesStatus.生效.ToString();
                }
                else
                {
                    return ServicesStatus.失效.ToString();
                }
            }
        }

        /// <summary>
        /// 产品类别 1普货，2敏感，3带电
        /// </summary>
        public string GoodsType { get; set; }

        public string GoodsTypeName
        {
            get
            {
                int s = 1;
                int.TryParse(GoodsType, out s);
                switch (s)
                {
                    case (int)ProductType.普货:
                        return ProductType.普货.ToString();
                    case (int)ProductType.敏感:
                        return ProductType.敏感.ToString();
                    case (int)ProductType.带电:
                        return ProductType.带电.ToString();
                }
                return ProductType.普货.ToString();
            }
        }

        public string Remark { get; set; }

        public string ShowWeb { get; set; }

        public string AllowApi { get; set; }

        public int VolParam { get; set; }
    }
}
