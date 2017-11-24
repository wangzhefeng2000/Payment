using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserTokenGetResponse.
    /// </summary>
    public class AlipayTrustUserTokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 本字段已废弃
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
