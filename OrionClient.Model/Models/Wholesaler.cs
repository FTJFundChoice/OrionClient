using System.Runtime.Serialization;

namespace OrionClient.Model.Models {

    [DataContract()]
    public class Wholesaler {

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}