using System;
using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Models {

    [DataContract()]
    public class BrokerDealer {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "portfolio")]
        public BrokerDealerPortfolio Portfolio { get; set; }
    }

    [DataContract()]
    public class BrokerDealerPortfolio {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "oldBDCode")]
        public string OldBDCode { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "address1")]
        public string Address1 { get; set; }

        [DataMember(Name = "address2")]
        public string Address2 { get; set; }

        [DataMember(Name = "address3")]
        public string Address3 { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "businessPhone")]
        public string BusinessPhone { get; set; }

        [DataMember(Name = "homePhone")]
        public string HomePhone { get; set; }

        [DataMember(Name = "otherPhone")]
        public string OtherPhone { get; set; }

        [DataMember(Name = "isActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "createdDate")]
        public DateTime CreatedDate { get; set; }

        [DataMember(Name = "editedBy")]
        public string EditedBy { get; set; }

        [DataMember(Name = "editedDate")]
        public string EditedDate { get; set; }
    }
}