using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Models.Trading
{
    public class SleeveStrategy: SleeveStrategyCore
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("contributionAllocationMethod")]
        public string ContributionAllocationMethod { get; set; }
        [JsonProperty("distributionAllocationMethod")]
        public string DistributionAllocationMethod { get; set; }      
        [JsonProperty("autoRebalFreq")]
        public string AutoRebalFreq {get;set;}
        [JsonProperty("autoRebalMonth")]
        public string AutoRebalMonth { get; set; }
        [JsonProperty("autoRebalDay")]
        public string AutoRebalDay { get; set; }
        [JsonProperty("mandate")]
        public bool Mandate { get; set; }
        [JsonProperty("entityId")]
        public int EntityId { get; set; }
        [JsonProperty("entityEnum")]
        public string EntityEnum { get; set; }
        [JsonProperty("originalRiskScore")]
        public int OriginalRiskScore { get; set; }
        [JsonProperty("sleeveStrategyRiskTypeId")]
        public int SleeveStrategyRiskTypeId { get; set; }
    }
}