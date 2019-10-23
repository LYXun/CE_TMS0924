using CE_TMS.COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.MODEL
{
    public class TmsServiceProvider:TmsObject
    {
        /// <summary>
        /// 服务商
        /// </summary>
        //public string Id { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceShortName { get; set; }
        public string ServiceFullName { get; set; }
        public string ServiceType { get; set; }
        public string HostOrgId { get; set; }
        public string HostOrgName { get; set; }
        public string ServiceTel { get; set; }
        public string ServiceAddress { get; set; }
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
    }
}
