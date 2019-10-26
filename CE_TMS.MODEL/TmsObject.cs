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


}
