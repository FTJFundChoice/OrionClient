using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels {

    public class Wholesaler {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}