using System;
using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Trading
{
    public class SleeveStrategyDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("sleeveStrategyId")]
        public int SleeveStrategyId { get; set; }
        [JsonProperty("aggregateModelId")]
        public int? AggregateModelId { get; set; }
        [JsonProperty("managementStyleId")]
        public int? ManagementStyleId { get; set; }
        [JsonProperty("subAdvisorId")]
        public int? SubAdvisorId { get; set; }
        [JsonProperty("targetAllocation")]
        public decimal TargetAllocation { get; set; }
        [JsonProperty("contributionAllocation")]
        public decimal ContributionAllocation { get; set; }
        [JsonProperty("distributionAllocation")]
        public decimal DistributionAllocation { get; set; }
        [JsonProperty("toleranceUpper")]
        public decimal ToleranceUpper { get; set; }
        [JsonProperty("toleranceLower")]
        public decimal ToleranceLower { get; set; }
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }
        [JsonProperty("editedBy")]
        public string EditedBy { get; set; }
        [JsonProperty("editedDate")]
        public DateTime EditedDate { get; set; }
        [JsonProperty("sleeveType")]
        public string SleeveType { get; set; }
        [JsonProperty("autoTradeTypes")]
        public string AutoTradeTypes { get; set; }
        [JsonProperty("aggregateName")]
        public string AggregateName { get; set; }
        [JsonProperty("managementStyleName")]
        public string ManagementStyleName { get; set; }
        [JsonProperty("subAdvisorName")]
        public string SubAdvisorName { get; set; }
        [JsonProperty("aggregateModelType")]
        public string AggregateModelType { get; set; }
        [JsonProperty("aggregateModelTypeId")]
        public int? AggregateModelTypeId { get; set; }
        [JsonProperty("riskScore")]
        public decimal RiskScore { get; set; }
    }
}
