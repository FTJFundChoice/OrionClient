using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class ClientSimple {

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("repCode")]
        public string RepCode { get; set; }
    }
}