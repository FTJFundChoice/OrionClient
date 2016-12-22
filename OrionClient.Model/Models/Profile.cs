using System.Runtime.Serialization;

namespace OrionClient.Model {

    public enum LoginEntityId {
        Dealer = 1,
        Rep = 3,
        Household = 4,
        Advisor = 5,
        SubAdvisor = 7
    }

    [DataContract()]
    public class Profile {

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "loginEntityId")]
        public LoginEntityId LoginEntityId { get; set; }

        [DataMember(Name = "entity")]
        public string Entity { get; set; }

        [DataMember(Name = "entityId")]
        public long EntityId { get; set; }

        [DataMember(Name = "advisorName")]
        public string AdvisorName { get; set; }

        [DataMember(Name = "entityName")]
        public string EntityName { get; set; }

        [DataMember(Name = "roleId")]
        public long RoleId { get; set; }

        [DataMember(Name = "isUserDefault")]
        public bool IsUserDefault { get; set; }

        [DataMember(Name = "alClientId")]
        public long AlClientId { get; set; }

        [DataMember(Name = "roleName")]
        public string RoleName { get; set; }

        [DataMember(Name = "isInCurrentDb")]
        public bool IsInCurrentDb { get; set; }
    }
}