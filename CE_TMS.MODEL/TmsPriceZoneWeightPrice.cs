namespace CES_TMS.MODEL
{
    /// <summary>
    /// 分区重量价格
    /// </summary>
    public class TmsPriceZoneWeightPrice
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 所属价格id
        /// </summary>
        public string HostCostId { get; set; }
        /// <summary>
        /// 所属分区方案下分区id
        /// </summary>
        public string HostZoneCountryId { get; set; }
        /// <summary>
        /// 所属分区方案下分区名称
        /// </summary>
        public string HostZoneCountryName { get; set; }
        /// <summary>
        /// 所属重量方案下重量段id
        /// </summary>
        public string HostWeightZoneId { get; set; }
        /// <summary>
        /// 所属重量方案下重量段名称
        /// </summary>
        public string HostWeightZoneName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// 杂费
        /// </summary>
        public decimal Fee { get; set; }

        /// <summary>
        /// 首重价格
        /// </summary>
        public decimal FirstPrice { get; set; }

        /// <summary>
        /// 首重结束，首重起始默认为0
        /// </summary>
        public decimal FirstEnd { get; set; }

        /// <summary>
        /// 类别：1，成本；2，销售；3，公布；4，协议；5，折扣
        /// </summary>
        public string Type { get; set; }

        public int OrderNo { get; set; }
    }
}