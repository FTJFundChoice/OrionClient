using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels {

    // Wholesaler and Wholesaler (Simple) return the same structure
    public class Wholesaler {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}