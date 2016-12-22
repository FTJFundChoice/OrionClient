using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels {

    public class SearchProfile {

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("loginUserId")]
        public string LoginUserId { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }

        [JsonProperty("userDetailId")]
        public string UserDetailId { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }

        [JsonProperty("userGuid")]
        public string UserGuid { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("entityId")]
        public long EntityId { get; set; }

        [JsonProperty("entityName")]
        public string EntityName { get; set; }
    }
}