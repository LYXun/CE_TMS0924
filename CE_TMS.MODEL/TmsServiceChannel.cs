using CE_TMS.COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.MODEL
{
    public class TmsServiceChannel:TmsObject
    {
        /// <summary>
        /// 所属服务商代码
        /// </summary>
        public string HostServiceCode { get; set; }
        /// <summary>
        /// 渠道代码
        /// </summary>
        public string ChannelCode { get; set; }
        /// <summary>
        /// 渠道简称
        /// </summary>
        public string ChannelShortName { get; set; }
        /// <summary>
        /// 渠道全称
        /// </summary>
        public string ChannelFullName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
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
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 标签模板，关联标签模板表
        /// </summary>
        public string LabelModel { get; set; }
        /// <summary>
        /// 发票模板，关联发票模板表
        /// </summary>
        public string InvModel { get; set; }
        /// <summary>
        /// 偏远地区校验规则，规则id
        /// </summary>
        public string IsolatedChecker { get; set; }
        /// <summary>
        /// 换单规则，0不换单；1强制换单；2不符合规则换单
        /// </summary>
        public string ChangeNo { get; set; }
        /// <summary>
        /// 出库包装类型 000    包裹，文件，其他
        /// </summary>
        public string OutWrapType { get; set; }
        /// <summary>
        /// 预报模板，关联预报模板表
        /// </summary>
        public string ForcastModel { get; set; }
        /// <summary>
        /// apicode 
        /// </summary>
        public string ApiCode { get; set; }
    }
}
