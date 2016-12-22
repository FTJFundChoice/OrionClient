using Newtonsoft.Json;

namespace FTJFundChoice.OrionModels {

    public enum LoginEntityId {
        Dealer = 1,
        Rep = 3,
        Household = 4,
        Advisor = 5,
        SubAdvisor = 7
    }

    public class Profile {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("loginEntityId")]
        public LoginEntityId LoginEntityId { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("entityId")]
        public long EntityId { get; set; }

        [JsonProperty("advisorName")]
        public string AdvisorName { get; set; }

        [JsonProperty("entityName")]
        public string EntityName { get; set; }

        [JsonProperty("roleId")]
        public long RoleId { get; set; }

        [JsonProperty("isUserDefault")]
        public bool IsUserDefault { get; set; }

        [JsonProperty("alClientId")]
        public long AlClientId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("isInCurrentDb")]
        public bool IsInCurrentDb { get; set; }
    }
}