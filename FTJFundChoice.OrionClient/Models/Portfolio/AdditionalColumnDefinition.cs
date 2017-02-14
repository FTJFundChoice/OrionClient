using FTJFundChoice.OrionClient.Models.Enums;
using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class AdditionalColumnDefinition {

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public AdditionalColumnType Type { get; set; }
    }
}