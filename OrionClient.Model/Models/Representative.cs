using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OrionClient.Model {

    [DataContract()]
    public class Representative {

        [DataMember(Name = "id")]
        public int? Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "portfolio")]
        public RepresentativePortfolio Portfolio { get; set; }

        [DataMember(Name = "userDefinedFields")]
        public IEnumerable<RepresentativeUserDefinedField> UserDefinedFields { get; set; }
    }

    [DataContract()]
    public class RepresentativePortfolio {

        [Obsolete("Do not use this value; use Representative.Id instead.")]
        [DataMember(Name = "id")]
        public int? Id { get; set; }

        [DataMember(Name = "brokerDealerId")]
        public long BrokerDealerId { get; set; }

        [DataMember(Name = "wholesalerId")]
        public long WholesalerId { get; set; }

        [DataMember(Name = "number")]
        public string Number { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

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

        [DataMember(Name = "startDate")]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "editedBy")]
        public string EditedBy { get; set; }

        [DataMember(Name = "editedDate")]
        public string EditedDate { get; set; }
    }

    public class RepresentativeUserDefinedField {

        [DataMember(Name = "userDefinedDefinitionId")]
        public int UserDefinedDefinitionId { get; set; }

        [DataMember(Name = "userDefinedDataId")]
        public int UserDefinedDataId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "sequence")]
        public int Sequence { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "entity")]
        public string Entity { get; set; }

        [DataMember(Name = "entityId")]
        public int EntityId { get; set; }
    }
}