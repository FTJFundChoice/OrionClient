using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels.Portfolio {

    public class SubAdvisorLogo {

        [JsonProperty("image")]
        public byte[] Image { get; set; }
    }
}