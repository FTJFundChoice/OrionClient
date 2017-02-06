using FTJFundChoice.OrionClient.Models.Enums;
using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Portfolio {

    public class SubAdvisorEntity {

        [JsonProperty("entity")]
        public Entity Entity { get; set; }

        [JsonProperty("entityId")]
        public long EntityId { get; set; }
    }
}