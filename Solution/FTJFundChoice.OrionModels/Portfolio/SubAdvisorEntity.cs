using FTJFundChoice.OrionModels.Enums;
using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels.Portfolio {

    public class SubAdvisorEntity {

        [JsonProperty("entity")]
        public Entity Entity { get; set; }

        [JsonProperty("entityId")]
        public long EntityId { get; set; }
    }
}