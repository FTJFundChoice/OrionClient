using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Portfolio {

    public class SubAdvisorSimple {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}