using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayKeyQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayKeyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝脱机交易公钥列表。列表中每一项为一个有效的支付宝公钥信息, 其中id字段表示支付宝公钥id。
        /// </summary>
        [JsonProperty("keys")]
        public List<AlipayOfflinePayMasterKey> Keys { get; set; }
    }
}
