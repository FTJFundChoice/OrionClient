using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Security {

    public class SetPassword {

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        [JsonProperty("isReset")]
        public bool IsReset { get; set; }
    }
}