using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class PlanSponsorSimple {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}