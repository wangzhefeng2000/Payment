using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentConstraintInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteligentConstraintInfo : AlipayObject
    {
        /// <summary>
        /// 人群组id，目前只支持返回时带出。
        /// </summary>
        [JsonProperty("crowd_group_id")]
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码
        /// </summary>
        [JsonProperty("item_ids")]
        [XmlElement("item_ids")]
        public string ItemIds { get; set; }

        /// <summary>
        /// 最低消费金额，单位元  仅在创建消费送礼包活动时设置
        /// </summary>
        [JsonProperty("min_cost")]
        [XmlElement("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店
        /// </summary>
        [JsonProperty("suit_shops")]
        [XmlArray("suit_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的次数限制  如果不设置则不限制参与次数
        /// </summary>
        [JsonProperty("user_win_count")]
        [XmlElement("user_win_count")]
        public string UserWinCount { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3
        /// </summary>
        [JsonProperty("user_win_frequency")]
        [XmlElement("user_win_frequency")]
        public string UserWinFrequency { get; set; }
    }
}
