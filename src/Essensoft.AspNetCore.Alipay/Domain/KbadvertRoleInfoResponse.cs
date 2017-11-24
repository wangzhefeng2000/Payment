using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KbadvertRoleInfoResponse Data Structure.
    /// </summary>
    public class KbadvertRoleInfoResponse : AlipayObject
    {
        /// <summary>
        /// 角色code
        /// </summary>
        [JsonProperty("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// NOT_OPEN:未开通  OPENED:已经开通
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
