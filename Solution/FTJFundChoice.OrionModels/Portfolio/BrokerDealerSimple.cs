using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels.Portfolio {

    public class BrokerDealerSimple {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}