using CES_TMS.COMMON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    public class TmsPriceZoneCountry:TmsObject
    {
        /// <summary>
        /// 分区名称
        /// </summary>
        public string ZoneName { get; set; }
        /// <summary>
        /// 国家代码
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// 国家名称
        /// </summary>
        public string CountryName { get; set; }

        [JsonIgnore]
        /// <summary>
        /// 
        /// </summary>
        public string CountryNameEn { get; set; }

        /// <summary>
        /// 城市id
        /// </summary>
        public string CityId { get; set; }
        /// <summary>
        /// 城市名称
        /// </summary>
        public string CityName { get; set; }
        /// <summary>
        /// 起始邮编
        /// </summary>
        public string ZipcodeBegin { get; set; }
        /// <summary>
        /// 结束邮编
        /// </summary>
        public string ZipcodeEnd { get; set; }
        /// <summary>
        /// 方案类型：1，国家；2，城市；3，邮编；
        /// </summary>
        public string Type { get; set; }

        [JsonIgnore]
        public string TypeName
        {
            get
            {
                int flag = 1;
                int.TryParse(Type, out flag);

                switch (flag)
                {
                    case 1:
                        return ZoneType.国家.ToString();
                    case 2:
                        return ZoneType.城市.ToString();
                    case 3:
                        return ZoneType.邮编.ToString();
                }

                return ZoneType.国家.ToString();
            }

        }

        /// <summary>
        /// 所属分区方案id
        /// </summary>
        public string HostZoneId { get; set; }

        /// <summary>
        /// 所属分区id
        /// </summary>
        public string BigZoneID { get; set; }

        /// <summary>
        /// 所属分区名称
        /// </summary>
        public string BigZoneName { get; set; }


        public int? OrderNo { get; set; }

        //public override bool Equals(object t)
        //{
        //    if (t == null || t as TmsPriceZoneCountry == null) {
        //        return false;
        //    }
        //    TmsPriceZoneCountry obj = t as TmsPriceZoneCountry;


        //    return (this.CountryCode.Equals(obj.CountryCode) && this.ZoneName.Equals(obj.ZoneName));
        //}

        public bool IDEquals(string id)
        {
            return this.Id.Equals(id);
        }

        /// <summary>
        /// 国家分区所属邮编信息
        /// </summary>
        //public List<TmsPriceZoneZipcode> ZipCodeList { get; set; }

        //public TmsPriceZoneCountry() {
        //    ZipCodeList = new List<TmsPriceZoneZipcode>();

        //}

    }
}
