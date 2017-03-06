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
        public SleeveStrategyCore Core { get; set; }
        [JsonProperty("mandates")]
        public List<Mandate> Mandates { get; set; }
        [JsonProperty("riskType")]
        public RiskType RiskTypes { get; set; }
        [JsonProperty("details")]
        public List<SleeveStrategyDetail> Details { get; set; }
    }
}
