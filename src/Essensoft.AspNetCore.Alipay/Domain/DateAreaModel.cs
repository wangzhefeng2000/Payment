using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// DateAreaModel Data Structure.
    /// </summary>
    public class DateAreaModel : AlipayObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}
