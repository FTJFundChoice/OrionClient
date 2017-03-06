using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Trading
{
    public class SleeveStrategyCore
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("contributionAllocationMethod")]
        public string ContributionAllocationMethod { get; set; }
        [JsonProperty("distributionAllocationMethod")]
        public string DistributionAllocationMethod { get; set; }
        [JsonProperty("autoRebalFreq")]
        public string AutoRebalFreq { get; set; }
        [JsonProperty("autoRebalMonth")]
        public int AutoRebalMonth { get; set; }
        [JsonProperty("autoRebalDay")]
        public int AutoRebalDay { get; set; }
        [JsonProperty("riskScore")]
        public decimal? RiskScore { get; set; }
        [JsonProperty("originalRiskScore")]
        public decimal? OriginalRiskScore { get; set; }
        [JsonProperty("sleeveStrategyRiskTypeId")]
        public int SleeveStrategyRiskTypeId { get; set; }
        [JsonProperty("entityId")]
        public int EntityId { get; set; }
        [JsonProperty("entityEnum")]
        public string EntityEnum { get; set; }
        [JsonProperty("strategyType")]
        public string StrategyType { get; set; }
        [JsonProperty("beta")]
        public decimal? Beta { get; set; }
        [JsonProperty("alpha")]
        public decimal? Alpha { get; set; }
        [JsonProperty("rSquared")]
        public decimal? RSquared { get; set; }
        [JsonProperty("drawdown")]
        public decimal? Drawdown { get; set; }
        [JsonProperty("ytd")]
        public decimal? YearToDate { get; set; }
        [JsonProperty("oneYr")]
        public decimal? OneYear { get; set; }
        [JsonProperty("threeYr")]
        public decimal? ThreeYear { get; set; }
        [JsonProperty("fiveYr")]
        public decimal? FiveYear { get; set; }

    }
}
