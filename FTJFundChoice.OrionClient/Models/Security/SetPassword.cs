using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Security {

    public class SetPassword {

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        [JsonProperty("resetUser")]
        public bool ResetUser { get; set; }
    }
}