using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Portfolio {

    public class RepresentativeSimple {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }
}