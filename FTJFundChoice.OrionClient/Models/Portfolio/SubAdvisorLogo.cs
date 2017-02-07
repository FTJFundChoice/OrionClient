using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class SubAdvisorLogo {

        [JsonProperty("image")]
        public byte[] Image { get; set; }
    }
}