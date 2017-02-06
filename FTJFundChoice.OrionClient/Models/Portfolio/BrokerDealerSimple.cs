using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Portfolio {

    public class BrokerDealerSimple {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}