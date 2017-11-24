using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesQueryRespModel Data Structure.
    /// </summary>
    public class FengdieSitesQueryRespModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶模板的最近修改日期
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 云凤蝶模板ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 云凤蝶模板是否上线的状态
        /// </summary>
        [JsonProperty("is_online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// 云凤蝶模板的下线日期
        /// </summary>
        [JsonProperty("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 云凤蝶模板的负责人
        /// </summary>
        [JsonProperty("owner")]
        public FengdieSitesOwner Owner { get; set; }

        /// <summary>
        /// 云凤蝶模板中所包含的页面
        /// </summary>
        [JsonProperty("pages")]
        public List<FengdieSitesPageModel> Pages { get; set; }

        /// <summary>
        /// 云凤蝶模板的当前状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 云凤蝶模板的名称
        /// </summary>
        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 云凤蝶模板的版本号
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 云凤蝶模板的标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
