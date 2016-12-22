using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Models {

    [DataContract()]
    public class Wholesaler {

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}