using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FTJFundChoice.OrionClient.Models {

    [DataContract()]
    public class Representative {

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "portfolio", EmitDefaultValue = false)]
        public RepresentativePortfolio Portfolio { get; set; }

        [DataMember(Name = "userDefinedFields", EmitDefaultValue = false)]
        public List<RepresentativeUserDefinedField> UserDefinedFields { get; set; }
    }

    [DataContract()]
    public class RepresentativePortfolio {

        [Obsolete("Do not use this value; use Representative.Id instead.")]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        [DataMember(Name = "brokerDealerId", EmitDefaultValue = false)]
        public long BrokerDealerId { get; set; }

        [DataMember(Name = "wholesalerId", EmitDefaultValue = false)]
        public long WholesalerId { get; set; }

        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(Name = "address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        [DataMember(Name = "address3", EmitDefaultValue = false)]
        public string Address3 { get; set; }

        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(Name = "businessPhone", EmitDefaultValue = false)]
        public string BusinessPhone { get; set; }

        [DataMember(Name = "homePhone", EmitDefaultValue = false)]
        public string HomePhone { get; set; }

        [DataMember(Name = "otherPhone", EmitDefaultValue = false)]
        public string OtherPhone { get; set; }

        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        public bool IsActive { get; set; }

        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "editedBy", EmitDefaultValue = false)]
        public string EditedBy { get; set; }

        [DataMember(Name = "editedDate", EmitDefaultValue = false)]
        public string EditedDate { get; set; }
    }

    [DataContract()]
    public class RepresentativeUserDefinedField {

        [DataMember(Name = "userDefineDefinitionId")]
        public int UserDefineDefinitionId { get; set; }

        [DataMember(Name = "userDefineDataId")]
        public int UserDefineDataId { get; set; }

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