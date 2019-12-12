namespace CES_TMS.MODEL
{
    /// <summary>
    /// 分区杂费
    /// </summary>
    public class TmsPriceZoneCountryFee
    {
        /// <summary>
        /// 分区杂费id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 所属价格id
        /// </summary>
        public string HostPriceCode { get; set; }

        /// <summary>
        /// 所属分区id
        /// </summary>
        public string HostZoneCountryId { get; set; }

        /// <summary>
        /// 杂费价
        /// </summary>
        public decimal Price { get; set; }
    }
}