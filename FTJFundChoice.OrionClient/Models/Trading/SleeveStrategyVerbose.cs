using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Trading
{
    public class SleeveStrategyVerbose
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("core")]
        public string Core { get; set; }
        [JsonProperty("mandates")]
        public string Mandates { get; set; }
        [JsonProperty("riskType")]
        public string RiskType { get; set; }
        [JsonProperty("details")]
        public List<SleeveStrategyCore> Details { get; set; }
    }
}
