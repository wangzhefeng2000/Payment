using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCraftsmanDataWorkDeleteModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，默认有效期24小时；isv自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 口碑手艺人id。是创建手艺人接口koubei.craftsman.data.provider.create返回的craftsman_id，或通过查询手艺人信息接口koubei.craftsman.data.provider查询craftsman_id
        /// </summary>
        [JsonProperty("craftsman_id")]
        public string CraftsmanId { get; set; }

        /// <summary>
        /// 口碑手艺人作品id列表，通过查询手艺人作品信息接口koubei.craftsman.data.work.batchquery获取work_id
        /// </summary>
        [JsonProperty("work_ids")]
        public List<string> WorkIds { get; set; }
    }
}
