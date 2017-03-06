using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Trading
{
    public class Mandate
    {
        [JsonProperty("sleeveStrategyId")]
        public int SleeveStrategyId { get; set; }
        [JsonProperty("modelAggTypeId")]
        public int ModelAggTypeId { get; set; }
        [JsonProperty("modelAggTypeName")]
        public string ModelAggTypeName { get; set; }
        [JsonProperty("riskScore")]
        public decimal? RiskScore { get; set; }
        [JsonProperty("allocation")]
        public decimal Allocation { get; set; }
        [JsonProperty("auditedDate")]
        public DateTime AuditedDate { get; set; }
        [JsonProperty("auditedByDisplay")]
        public string AuditedByDisplay { get; set; }

    }
}
