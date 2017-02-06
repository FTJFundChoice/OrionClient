using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Portfolio {

    public class SubAdvisorLogo {

        [JsonProperty("image")]
        public byte[] Image { get; set; }
    }
}