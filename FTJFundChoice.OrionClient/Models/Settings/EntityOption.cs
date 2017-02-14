using FTJFundChoice.OrionClient.Models.Enums;
using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Settings {

    public class EntityOption {

        [JsonProperty("canEdit")]
        public bool CanEdit { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("childParameter")]
        public string ChildParameter { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("entity")]
        public Entity Entity { get; set; }

        [JsonProperty("entityId")]
        public long? EntityId { get; set; }

        [JsonProperty("entityName")]
        public string EntityName { get; set; }

        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public dynamic Options { get; set; }

        [JsonProperty("securityCode")]
        public string SecurityCode { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("type")]
        public UserDefineControlMask Type { get; set; }

        [JsonProperty("userDefineDataId")]
        public long UserDefineDataId { get; set; }

        [JsonProperty("userDefineDefinitionId")]
        public long UserDefineDefinitionId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}