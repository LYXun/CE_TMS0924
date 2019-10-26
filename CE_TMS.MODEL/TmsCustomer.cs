using CES_TMS.COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.MODEL
{
    public class TmsCustomer
    {
        public string Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerShortName { get; set; }
        public string CustomerFullName { get; set; }
        public string Status { get; set; }

        public string StatusName
        {
            get
            {
                int flag = 1;
                int.TryParse(Status, out flag);
                switch (flag)
                {
                    case 1:
                        return ChannelStatus.正常.ToString();
                    case 2:
                        return ChannelStatus.锁定.ToString();
                    case 3:
                        return ChannelStatus.作废.ToString();
                }
                return ChannelStatus.正常.ToString();
            }
        }

        public string PayType { get; set; }
        //结算方式


        public string CustomerType { get; set; }

        public string CustomerTypeName
        {
            get
            {
                int flag = 1;
                int.TryParse(CustomerType, out flag);
                switch (flag)
                {
                    case 1:
                        return CustomerTypeA.个人.ToString();
                    case 2:
                        return CustomerTypeA.代理.ToString();
                    case 3:
                        return CustomerTypeA.平台.ToString();
                    case 4:
                        return CustomerTypeA.公司.ToString();
                }
                return CustomerTypeA.个人.ToString();
            }
        }

        public string HostOrgId { get; set; }
        public string HostOrgName { get; set; }
        public string SaleId { get; set; }
        public string SaleName { get; set; }
        public string FinanceId { get; set; }
        public string FinanceName { get; set; }
        public string CsId { get; set; }
        public string CsName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateOpId { get; set; }
        public string CreateOpName { get; set; }
        public string Token { get; set; }
        public string Key { get; set; }

        public string LinkMan { get; set; }
        public string LinkTel { get; set; }
        public string LinkAddress { get; set; }
        public decimal? Amount { get; set; }
        /// <summary>
        /// 客户类别
        /// </summary>
        public string CustomerKind { get; set; }

        /// <summary>
        /// 客户类别id
        /// </summary>
        public string CustomerKindId { get; set; }

        /// <summary>
        /// 账户额度
        /// </summary>
        public decimal? Credit { get; set; }

        /// <summary>
        /// 是否直接使用服务商单号和面单
        /// </summary>
        public string IsServiceInfo { get; set; }

        /// <summary>
        /// 绑定  CustomerAddress 表 
        /// </summary>
        public string DefultAddressID { get; set; }
    }
}
