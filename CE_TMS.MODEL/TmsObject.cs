using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES_TMS.COMMON
{
    public class TmsObject
    {
        public string Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public string CreateOpId { get; set; }

        public string CreateOpName { get; set; }


        public TmsObject()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreateTime = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day).ToLocalTime();
        }
    }
    public enum CustomerTypeA : int
    {
        个人 = 1,
        代理 = 2,
        平台 = 3,
        公司 = 4
    }

    //渠道状态
    public enum ChannelStatus : int
    {
        正常 = 1,
        锁定 = 2,
        作废 = 3
    }

    public enum PayTypeName1: int
    {
        周结 = 1,
        半月结 = 2,
        月结 = 3,
        现付 = 4
    }

    public enum ServicesStatus :int
    {
        生效 = 1,
        失效 = 2
    }

    public enum ZoneStatus : int
    {
        草稿 = 1,
        发布 = 2,
        作废 = 3
    }

    public enum GoodsTypeNames : int
    {
        袋子 = 1,
        文件 = 2,
        包裹 = 3
    }

    public enum ProductType : int
    {
        普货 = 1,
        敏感 = 2,
        带电 = 3
    };

    public enum PriceOperation : int
    {
        加 = 1,
        减 = 2,
        乘 = 3,
        除 = 4
    };

    public enum PriceType : int
    {
        成本 = 1,
        销售 = 2,
        公布 = 3,
        协议 = 4,
        折扣 = 5,
        类别 = 6
    }

    /// <summary>
    /// 类别：1，成本；2，销售；3，公布；4，协议；5，折扣；6，类别价；
    /// </summary>
    public enum PriceServicesKey : int
    {
        CostPrice = 1,
        SalePrice = 2,
        PublishPrice = 3,
        AgreePrice = 4,
        DiscountPrice = 5,
        KindPrice = 6,
    };

}
