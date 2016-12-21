using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OrionClient {

    [DataContract()]
    public class OrionException {

        [DataMember(Name = "correlationId")]
        public string CorrelationId { get; set; }

        [DataMember(Name = "developerException")]
        public string DeveloperException { get; set; }

        [DataMember(Name = "userException")]
        public UserException UserException { get; set; }
    }

    [DataContract()]
    public class UserException {

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "detail")]
        public List<OrionKeyValue> Detail { get; set; }
    }

    [DataContract()]
    public class OrionKeyValue {

        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}