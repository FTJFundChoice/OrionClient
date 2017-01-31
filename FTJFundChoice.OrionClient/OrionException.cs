using Newtonsoft.Json;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient {

    public class OrionException {

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("developerException")]
        public string DeveloperException { get; set; }

        [JsonProperty("userException")]
        public UserException UserException { get; set; }
    }

    public class UserException {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("detail")]
        public List<OrionKeyValue> Detail { get; set; }
    }

    public class OrionKeyValue {

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}