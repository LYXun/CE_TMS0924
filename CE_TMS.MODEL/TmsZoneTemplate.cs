using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    public class TmsZoneTemplate
    {
        /// <summary>
        /// 价格模板ID（公布价、成本价、销售价、客户协议价）对象ID
        /// </summary>
        public string PriceTemplateID { get; set; }
        /// <summary>
        /// 分区方案ID
        /// </summary>
        public string ZoneTemplateID { get; set; }
        /// <summary>
        /// 分区方案名称(总的方案名称)
        /// </summary>
        public string ZoneTemplateName { get; set; }
        /// <summary>
        /// 分区方案明细信息，（分区名称，对应分区的国家信息）
        /// </summary>
        //public Dictionary<string, List<TmsPriceZoneCountry>> ZoneDetialList { get; set; }

        //public List<TmsPriceZoneCountry> AllZoneCountryList {
        //    get
        //    {
        //        if (ZoneDetialList == null)
        //            return null;

        //        List<TmsPriceZoneCountry> allList = new List<TmsPriceZoneCountry>();
        //        List<TmsPriceZoneCountry> list;
        //        foreach (var key in ZoneDetialList.Keys)
        //        {
        //            list = ZoneDetialList[key];
        //            allList.AddRange(list);
        //        }

        //        return allList;
        //    }
        //    //set {
        //    //    this.AllZoneCountryList = value;
        //    //}
        //}

        public List<TmsPriceZoneCountry> AllZoneCountryList
        {
            get; set;
        }

        /// <summary>
        /// 重量模板名称（总的重量名称）
        /// </summary>
        public string ZoneWeigthTemplateName { get; set; }

        public string ZoneWeigthTemplateID { get; set; }

        /// <summary>
        /// 分区重量模板信息 1个分区对应多个重量模板（分区名称，对应重量模板信息）
        /// </summary>
        //public Dictionary<string, List<TmsPriceWeightZone>> ZoneWeightDetailList { get; set; }

        public List<TmsPriceWeightZone> ZoneWeightList { get; set; }

        /// <summary>
        ///价格段类别 
        /// </summary>
        public List<TmsPriceZoneWeightPrice> ZonePriceList { get; set; }

        /// <summary>
        /// 分区杂费
        /// </summary>
        public List<TmsPriceZoneCountryFee> ZoneFeeList { get; set; }

        public TmsZoneTemplate()
        {
            //ZoneDetialList = new Dictionary<string, List<TmsPriceZoneCountry>>();
            AllZoneCountryList = new List<TmsPriceZoneCountry>();
            ZoneWeightList = new List<TmsPriceWeightZone>();
            ZonePriceList = new List<TmsPriceZoneWeightPrice>();
        }

        public void AddCountry(string zoneName, string templateId, List<TmsCodeCountry> countryList)
        {
            int seqIndex = AllZoneCountryList.Count;

            for (int i = 0; i < countryList.Count; i++)
            {
                AllZoneCountryList.Add(new TmsPriceZoneCountry()
                {
                    Id = Guid.NewGuid().ToString(),
                    OrderNo = seqIndex + i + 1,
                    ZoneName = countryList[i].CountryCode,
                    HostZoneId = templateId,
                    CountryCode = countryList[i].CountryCode,
                    CountryName = countryList[i].CountryNameCn,
                    Type = ((int)ZoneType.国家).ToString()
                });
            }

            this.AllZoneCountryList = this.AllZoneCountryList.OrderBy(o => o.OrderNo).ToList();
        }

    }
}
