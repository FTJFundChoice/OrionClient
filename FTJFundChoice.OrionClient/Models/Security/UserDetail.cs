using FTJFundChoice.OrionClient.Models.Enums;
using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Security {

    public class UserDetail {

        [JsonProperty("userName")]
        public string Username { get; set; }

        [JsonProperty("loginUserId")]
        public string LoginUserId { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }

        [JsonProperty("userDetailId")]
        public long UserDetailId { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }

        [JsonProperty("userGuid")]
        public string UserGuid { get; set; }

        [JsonProperty("entity")]
        public Entity Entity { get; set; }

        [JsonProperty("entityId")]
        public long? EntityId { get; set; }

        [JsonProperty("entityName")]
        public string EntityName { get; set; }
    }
}