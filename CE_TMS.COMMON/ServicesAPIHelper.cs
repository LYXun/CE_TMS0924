using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CES_TMS.COMMON
{
    public class ServicesAPIHelper
    {
        public static ServicesAPIHelper instance = null;
        private static object lockHelper = new object();
        public string BaseUrl = ConfigurationManager.AppSettings["BaseUrl"].ToString();
        public string IdpBaseUrl = ConfigurationManager.AppSettings["IdpBaseUrl"].ToString();

        private ServicesAPIHelper()
        {

        }
        public static ServicesAPIHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(lockHelper)
                    {
                        if(instance == null)
                        {
                            instance = new ServicesAPIHelper();

                        }
                    }
                }
                return instance;
            }
           
        }

        #region  LoginUrl
        public string LoginUrl
        {
            get
            {
                return IdpBaseUrl + ConfigurationManager.AppSettings["LoginUrl"].ToString();
            }
        }
        #endregion

        #region order
        public string OrderQueryOrderListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderQueryOrderListUrl"].ToString();
            }
        }

        public string OrderQueryOrderListARUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderQueryOrderListARUrl"].ToString();
            }
        }

        public string QueryOrderByServiceNoUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["QueryOrderByServiceNoUrl"].ToString();
            }
        }

        public string OrderAddOrderUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderAddOrderUrl"].ToString();
            }
        }

        public string OrderAddOrdersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderAddOrdersUrl"].ToString();
            }
        }

        public string OrderUpdateOrderUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderUpdateOrderUrl"].ToString();
            }
        }

        public string OrderUpdateOrdersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderUpdateOrdersUrl"].ToString();
            }
        }

        public string OrderQueryOrderByIdUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderQueryOrderByIdUrl"].ToString();
            }
        }

        public string QueryOrderUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["QueryOrderUrl"].ToString();
            }
        }

        public string QueryOrderExistUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["QueryOrderExistUrl"].ToString();
            }
        }

        public string QueryOrderExistListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["QueryOrderExistListUrl"].ToString();
            }
        }
        #endregion

        #region orderGoods
        public string OrderGoodsQueryOrderGoodsListUrl
        {
            get
            {
                return BaseUrl + ConfigurationManager.AppSettings["OrderGoodsQueryOrderGoodsListUrl"].ToString();
            }
        }
        #endregion

        #region bag
        public string BagQueryBagListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagQueryBagListUrl"].ToString();
            }
        }

        public string BagAddBagUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagAddBagUrl"].ToString();
            }
        }

        public string BagUpdateBagUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagUpdateBagUrl"].ToString();
            }
        }

        public string BagDeleteBagUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagDeleteBagUrl"].ToString();
            }
        }

        public string BagQueryBagUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagQueryBagUrl"].ToString();
            }
        }

        public string BagAutoAddBagUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagAutoAddBagUrl"].ToString();
            }
        }
        #endregion

        #region arrivalBill
        public string ArrivalBillQueryArrivalBillListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ArrivalBillQueryArrivalBillListUrl"].ToString();
            }
        }

        public string ArrivalBillQueryArrivalBillListByNoUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ArrivalBillQueryArrivalBillListByNoUrl"].ToString();
            }
        }

        public string ArrivalBillQueryArrivalBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ArrivalBillQueryArrivalBillUrl"].ToString();
            }
        }

        public string ArrivalBillAddArrivalBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ArrivalBillAddArrivalBillUrl"].ToString();
            }
        }

        public string ArrivalBillUpdateArrivalBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ArrivalBillUpdateArrivalBillUrl"].ToString();
            }
        }

        public string ArrivalBillDeleteArrivalBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ArrivalBillDeleteArrivalBillUrl"].ToString();
            }
        }
        #endregion

        #region outBill
        public string OutBillQueryOutBillListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OutBillQueryOutBillListUrl"].ToString();
            }
        }

        public string OutBillQueryOutBillListByNoUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OutBillQueryOutBillListByNoUrl"].ToString();
            }
        }

        public string OutBillQueryOutBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OutBillQueryOutBillUrl"].ToString();
            }
        }

        public string OutBillAddOutBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OutBillAddOutBillUrl"].ToString();
            }
        }

        public string OutBillUpdateOutBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OutBillUpdateOutBillUrl"].ToString();
            }
        }

        public string OutBillDeleteOutBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OutBillDeleteOutBillUrl"].ToString();
            }
        }
        #endregion

        #region transBill
        public string TransBillQueryTransBillListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["TransBillQueryTransBillListUrl"].ToString();
            }
        }

        public string TransBillQueryTransBillListByNoUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["TransBillQueryTransBillListByNoUrl"].ToString();
            }
        }

        public string TransBillQueryTransBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["TransBillQueryTransBillUrl"].ToString();
            }
        }

        public string TransBillAddTransBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["TransBillAddTransBillUrl"].ToString();
            }
        }

        public string TransBillUpdateTransBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["TransBillUpdateTransBillUrl"].ToString();
            }
        }

        public string TransBillDeleteTransBillUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["TransBillDeleteTransBillUrl"].ToString();
            }
        }
        #endregion

        #region customer
        public string CustomerQueryListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerQueryListUrl"].ToString();
            }
        }

        public string CustomerQueryCustomerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerQueryCustomerUrl"].ToString();
            }
        }

        public string CustomerAddCustomerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerAddCustomerUrl"].ToString();
            }
        }

        public string CustomerAddCustomersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerAddCustomersUrl"].ToString();
            }
        }

        public string CustomerUpdateCustomerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerUpdateCustomerUrl"].ToString();
            }
        }

        public string CustomerUpdateCustomerFeeUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerUpdateCustomerFeeUrl"].ToString();
            }
        }

        public string CustomerGetLableUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerGetLableUrl"].ToString();
            }
        }

        public string CustomerUpdateCustomerKindUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CustomerUpdateCustomerKindUrl"].ToString();
            }
        }
        #endregion

        #region customeraddress
        public string AddParamsAddress
        {
            get
            {
                return BaseUrl + ConfigurationManager.AppSettings["AddParamsAddress"].ToString();
            }
        }

        public string UpdateParamsAddress
        {
            get
            {
                return BaseUrl + ConfigurationManager.AppSettings["UpdateParamsAddress"].ToString();
            }
        }

        public string DeleteParams
        {
            get
            {
                return BaseUrl + ConfigurationManager.AppSettings["DeleteParams"].ToString();
            }
        }

        public string GetParamsAddress
        {
            get
            {
                return BaseUrl + ConfigurationManager.AppSettings["GetParamsAddress"].ToString();
            }
        }

        public string GetParamsList
        {
            get
            {
                return BaseUrl + ConfigurationManager.AppSettings["GetParamsList"].ToString();
            }
        }
        #endregion

        #region  SysUserInfo
        public string SysUserInfoAddUserUrl
        {
            get
            {
                return IdpBaseUrl + ConfigurationManager.AppSettings["SysUserInfoAddUserUrl"].ToString();
            }
        }

        public string SysUserInfoUpdateUserUrl
        {
            get
            {
                return IdpBaseUrl + ConfigurationManager.AppSettings["SysUserInfoUpdateUserUrl"].ToString();
            }
        }

        public string SysUserInfoQueryUserByIDUrl
        {
            get
            {
                return IdpBaseUrl + ConfigurationManager.AppSettings["SysUserInfoQueryUserByIDUrl"].ToString();
            }
        }

        public string SysUserInfoQueryUserByNameUrl
        {
            get
            {
                return IdpBaseUrl + ConfigurationManager.AppSettings["SysUserInfoQueryUserByNameUrl"].ToString();
            }
        }
        #endregion

        #region UserRoleMap
        public string UserRoleMapAddUserRoleUrl
        {
            get
            {
                return IdpBaseUrl + ConfigurationManager.AppSettings["UserRoleMapAddUserRoleUrl"].ToString();
            }
        }
        #endregion

        #region customerKind
        public string ParamCustomerKindListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ParamCustomerKindListUrl"].ToString();
            }
        }

        public string ParamCustomerKindUpdateUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ParamCustomerKindUpdateUrl"].ToString();
            }
        }

        public string ParamCustomerKindAddUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ParamCustomerKindAddUrl"].ToString();
            }
        }

        public string ParamCustomerKindDeleteUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ParamCustomerKindDeleteUrl"].ToString();
            }
        }
        #endregion

        #region serviceChannel
        public string ServiceChannelQueryListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceChannelQueryListUrl"].ToString();
            }
        }

        public string ServiceChannelQueryServiceChannelUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceChannelQueryServiceChannelUrl"].ToString();
            }
        }

        public string ServiceChannelAddServiceChannelUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceChannelAddServiceChannelUrl"].ToString();
            }
        }

        public string ServiceChannelAddServiceChannelsUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceChannelAddServiceChannelsUrl"].ToString();
            }
        }

        public string ServiceChannelUpdateServiceChannelUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceChannelUpdateServiceChannelUrl"].ToString();
            }
        }
        #endregion

        #region serviceProvider
        public string ServiceProviderQueryListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProviderQueryListUrl"].ToString();
            }
        }

        public string ServiceProviderQueryServiceProviderUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProviderQueryServiceProviderUrl"].ToString();
            }
        }

        public string ServiceProviderAddServiceProviderUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProviderAddServiceProviderUrl"].ToString();
            }
        }

        public string ServiceProviderAddServiceProvidersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProviderAddServiceProvidersUrl"].ToString();
            }
        }

        public string ServiceProviderUpdateServiceProviderUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProviderUpdateServiceProviderUrl"].ToString();
            }
        }
        #endregion

        #region serviceProduct
        public string ServiceProductQueryListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProductQueryListUrl"].ToString();
            }
        }

        public string ServiceProductQueryServiceProductUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProductQueryServiceProductUrl"].ToString();
            }
        }

        public string ServiceProductAddServiceProductUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProductAddServiceProductUrl"].ToString();
            }
        }

        public string ServiceProductAddServiceProductsUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProductAddServiceProductsUrl"].ToString();
            }
        }

        public string ServiceProductUpdateServiceProductUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ServiceProductUpdateServiceProductUrl"].ToString();
            }
        }
        #endregion

        #region orderLogger
        public string OrderLoggerQueryLoggerListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderLoggerQueryLoggerListUrl"].ToString();
            }
        }

        public string OrderLoggerAddLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderLoggerAddLoggerUrl"].ToString();
            }
        }

        public string OrderLoggerAddLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderLoggerAddLoggersUrl"].ToString();
            }
        }

        public string OrderLoggerUpdateLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderLoggerUpdateLoggerUrl"].ToString();
            }
        }

        public string OrderLoggerUpdateLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderLoggerUpdateLoggersUrl"].ToString();
            }
        }

        public string OrderLoggerDeleteLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["OrderLoggerDeleteLoggerUrl"].ToString();
            }
        }
        #endregion

        #region bagLogger
        public string BagLoggerQueryLoggerListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagLoggerQueryLoggerListUrl"].ToString();
            }
        }

        public string BagLoggerAddLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagLoggerAddLoggerUrl"].ToString();
            }
        }

        public string BagLoggerAddLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagLoggerAddLoggersUrl"].ToString();
            }
        }

        public string BagLoggerUpdateLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagLoggerUpdateLoggerUrl"].ToString();
            }
        }

        public string BagLoggerUpdateLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagLoggerUpdateLoggersUrl"].ToString();
            }
        }

        public string BagLoggerDeleteLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BagLoggerDeleteLoggerUrl"].ToString();
            }
        }
        #endregion

        #region billLogger
        public string BillLoggerQueryLoggerListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillLoggerQueryLoggerListUrl"].ToString();
            }
        }

        public string BillLoggerAddLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillLoggerAddLoggerUrl"].ToString();
            }
        }

        public string BillLoggerAddLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillLoggerAddLoggersUrl"].ToString();
            }
        }

        public string BillLoggerUpdateLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillLoggerUpdateLoggerUrl"].ToString();
            }
        }

        public string BillLoggerUpdateLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillLoggerUpdateLoggersUrl"].ToString();
            }
        }

        public string BillLoggerDeleteLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillLoggerDeleteLoggerUrl"].ToString();
            }
        }
        #endregion

        #region errorLogger
        public string ErrorLoggerQueryLoggerListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ErrorLoggerQueryLoggerListUrl"].ToString();
            }
        }

        public string ErrorLoggerAddLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ErrorLoggerAddLoggerUrl"].ToString();
            }
        }

        public string ErrorLoggerAddLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ErrorLoggerAddLoggersUrl"].ToString();
            }
        }

        public string ErrorLoggerUpdateLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ErrorLoggerUpdateLoggerUrl"].ToString();
            }
        }

        public string ErrorLoggerUpdateLoggersUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ErrorLoggerUpdateLoggersUrl"].ToString();
            }
        }

        public string ErrorLoggerDeleteLoggerUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ErrorLoggerDeleteLoggerUrl"].ToString();
            }
        }
        #endregion

        #region price

        public string PriceQueryPricesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceQueryPricesUrl"].ToString();
            }
        }

        public string PriceQueryPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceQueryPriceUrl"].ToString();
            }
        }

        public string PriceQueryCalcPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceQueryCalcPriceUrl"].ToString();
            }
        }

        public string PricePreLoadPricesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PricePreLoadPricesUrl"].ToString();
            }
        }

        public string PriceCalePriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceCalePriceUrl"].ToString();
            }
        }

        public string PriceAddPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceAddPriceUrl"].ToString();
            }
        }

        public string PriceUpdatePriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceUpdatePriceUrl"].ToString();
            }
        }

        public string PriceAddZoneUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceAddZoneUrl"].ToString();
            }
        }

        public string PriceUpdatePriceStatusUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceUpdatePriceStatusUrl"].ToString();
            }
        }

        public string PriceUpdateZoneUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceUpdateZoneUrl"].ToString();
            }
        }

        public string PriceUpdateZoneStatusUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceUpdateZoneStatusUrl"].ToString();
            }
        }

        public string PriceDeleteUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceDeletePriceUrl"].ToString();
            }
        }

        public string PriceExistPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PriceExistPriceUrl"].ToString();
            }
        }

        #region costPrice
        public string CostPriceQueryPricesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CostPriceQueryPricesUrl"].ToString();
            }
        }

        public string CostPriceQueryPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CostPriceQueryPriceUrl"].ToString();
            }
        }

        public string CostPriceQueryCalcPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CostPriceQueryCalcPriceUrl"].ToString();
            }
        }

        public string CostPriceAddPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CostPriceAddPriceUrl"].ToString();
            }
        }

        public string CostPriceUpdatePriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["CostPriceUpdatePriceUrl"].ToString();
            }
        }
        #endregion

        #region publishPrice

        public string PublishPriceQueryPricesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PublishPriceQueryPricesUrl"].ToString();
            }
        }

        public string PublishPriceQueryPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PublishPriceQueryPriceUrl"].ToString();
            }
        }

        public string PublishPriceQueryCalcPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PublishPriceQueryCalcPriceUrl"].ToString();
            }
        }

        public string PublishPriceAddPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PublishPriceAddPriceUrl"].ToString();
            }
        }

        public string PublishPriceUpdatePriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PublishPriceUpdatePriceUrl"].ToString();
            }
        }
        #endregion

        #region salePrice
        public string SalePriceQueryPricesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["SalePriceQueryPricesUrl"].ToString();
            }
        }

        public string SalePriceQueryPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["SalePriceQueryPriceUrl"].ToString();
            }
        }

        public string SalePriceQueryCalcPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["SalePriceQueryCalcPriceUrl"].ToString();
            }
        }

        public string SalePriceAddPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["SalePriceAddPriceUrl"].ToString();
            }
        }

        public string SalePriceUpdatePriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["SalePriceUpdatePriceUrl"].ToString();
            }
        }
        #endregion

        #region agree
        public string AgreePriceQueryPricesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["AgreePriceQueryPricesUrl"].ToString();
            }
        }

        public string AgreePriceQueryPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["AgreePriceQueryPriceUrl"].ToString();
            }
        }
        #endregion

        #region discount

        public string DiscountPriceQueryPricesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["DiscountPriceQueryPricesUrl"].ToString();
            }
        }

        public string DiscountPriceQueryPriceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["DiscountPriceQueryPriceUrl"].ToString();
            }
        }

        #endregion

        #region weightPlan
        public string WeightPlanQueryListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["WeightPlanQueryListUrl"].ToString();
            }
        }

        public string WeightPlanQueryPLanByIdUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["WeightPlanQueryPLanByIdUrl"].ToString();
            }
        }

        public string WeightPlanQueryPLanDetailByIdUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["WeightPlanQueryPLanDetailByIdUrl"].ToString();
            }
        }

        public string WeightPlanAddPlanUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["WeightPlanAddPlanUrl"].ToString();
            }
        }

        public string WeightPlanUpdatePlanUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["WeightPlanUpdatePlanUrl"].ToString();
            }
        }

        public string WeightPlanDeletePlanUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["WeightPlanDeletePlanUrl"].ToString();
            }
        }
        #endregion

        #region zonePlan
        public string ZonePlanQueryListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ZonePlanQueryListUrl"].ToString();
            }
        }

        public string ZonePlanQueryPLanByIdUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ZonePlanQueryPLanByIdUrl"].ToString();
            }
        }

        public string ZonePlanQueryPLanDetailByIdUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ZonePlanQueryPLanDetailByIdUrl"].ToString();
            }
        }

        public string ZonePlanAddPlanUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ZonePlanAddPlanUrl"].ToString();
            }
        }

        public string ZonePlanUpdatePlanUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ZonePlanUpdatePlanUrl"].ToString();
            }
        }

        public string ZonePlanDeletePlanUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ZonePlanDeletePlanUrl"].ToString();
            }
        }
        #endregion

        #endregion

        #region country
        public string ParamQueryCountryListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ParamQueryCountryListUrl"].ToString();
            }
        }
        #endregion

        #region provier
        public string ProviderCreateAndPreAlertOrderListServiceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderCreateAndPreAlertOrderListServiceUrl"].ToString();
            }
        }

        public string ProviderCreateAndPreAlertOrderServiceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderCreateAndPreAlertOrderServiceUrl"].ToString();
            }
        }

        public string ProviderCancelOrderServiceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderCancelOrderServiceUrl"].ToString();
            }
        }

        public string ProviderModifiyOrderWeightServiceUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderModifiyOrderWeightServiceUrl"].ToString();
            }
        }

        public string ProviderGetLabelUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderGetLabelUrl"].ToString();
            }
        }

        public string ProviderOrderTransportationUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderOrderTransportationUrl"].ToString();
            }
        }

        //public string ProviderListOrderTransportationUrl
        //{
        //    get
        //    {
        //        return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderListOrderTransportationUrl"].ToString();
        //    }
        //}

        public string ProviderOrderDeliveryIsYesUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderOrderDeliveryIsYesUrl"].ToString();
            }
        }

        public string ProviderQueryOrderUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderQueryOrderUrl"].ToString();
            }
        }

        public string ProviderQueryOrderRouteUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderQueryOrderRouteUrl"].ToString();
            }
        }

        public string ProviderPutinStorageUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderPutinStorageUrl"].ToString();
            }
        }

        public string ProviderListOrderTransportationUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderListOrderTransportationUrl"].ToString();
            }
        }

        public string ProviderGetLabelPrintUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["ProviderGetLabelPrintUrl"].ToString();
            }
        }
        #endregion

        #region bill
        public string BillQueryBillDetailListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillQueryBillDetailListUrl"].ToString();
            }
        }

        public string BillAddBillDetailUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillAddBillDetailUrl"].ToString();
            }
        }

        public string BillAddBillDetailListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillAddBillDetailListUrl"].ToString();
            }
        }

        public string BillDeleteBillDetailUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["BillDeleteBillDetailUrl"].ToString();
            }
        }
        #endregion

        #region  payOutBill
        public string PayOutBillQueryBillDetailListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillQueryBillDetailListUrl"].ToString();
            }
        }

        public string PayOutBillAddBillDetailUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillAddBillDetailUrl"].ToString();
            }
        }

        public string PayOutBillAddBillDetailListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillAddBillDetailListUrl"].ToString();
            }
        }

        public string PayOutBillUpdateBillDetailUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillUpdateBillDetailUrl"].ToString();
            }
        }

        public string PayOutBillUpdateBillDetailListUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillUpdateBillDetailListUrl"].ToString();
            }
        }

        public string PayOutBillUpdateBillNoUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillUpdateBillDetailUrl"].ToString();
            }
        }

        public string PayOutBillWriteOffUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillWriteOffUrl"].ToString();
            }
        }

        public string PayOutBillDeleteBillDetailUrl
        {
            get
            {
                return BaseUrl + System.Configuration.ConfigurationManager.AppSettings["PayOutBillDeleteBillDetailUrl"].ToString();
            }
        }
        #endregion

    }
}
