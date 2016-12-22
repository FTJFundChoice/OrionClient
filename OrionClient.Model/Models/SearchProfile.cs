using System.Runtime.Serialization;

namespace OrionClient.Model {

    [DataContract()]
    public class SearchProfile {

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "loginUserId")]
        public string LoginUserId { get; set; }

        [DataMember(Name = "userId")]
        public long UserId { get; set; }

        [DataMember(Name = "userDetailId")]
        public string UserDetailId { get; set; }

        [DataMember(Name = "selected")]
        public bool Selected { get; set; }

        [DataMember(Name = "userGuid")]
        public string UserGuid { get; set; }

        [DataMember(Name = "entity")]
        public string Entity { get; set; }

        [DataMember(Name = "entityId")]
        public long EntityId { get; set; }

        [DataMember(Name = "entityName")]
        public string EntityName { get; set; }
    }
}