using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;


namespace FTJFundChoice.OrionClient.Models.Trading
{
    public class RiskType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("lowerLimit")]
        public decimal LowerLimit { get; set; }
        [JsonProperty("upperLimit")]
        public decimal UpperLimit { get; set; }
        [JsonProperty("auditedDate")]
        public DateTime? AuditedDate { get; set; }
        [JsonProperty("AuditedByDisplay")]
        public string AuditedByDisplay { get; set; }
        [JsonProperty("isPtModel")]
        public bool IsPtModel { get; set; }
        [JsonProperty("riskTypeAllocations")]
        public List<RisTypeAllocation> RiskTypeAllocations { get; set; }
    }
}