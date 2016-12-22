using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FTJFundChoice.OrionModels {

    public class Representative {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("portfolio")]
        public RepresentativePortfolio Portfolio { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<RepresentativeUserDefinedField> UserDefinedFields { get; set; }
    }

    public class RepresentativePortfolio {

        [Obsolete("Do not use this value; use Representative.Id instead.")]
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("brokerDealerId")]
        public long? BrokerDealerId { get; set; }

        [JsonProperty("wholesalerId")]
        public long? WholesalerId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("businessPhone")]
        public string BusinessPhone { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("otherPhone")]
        public string OtherPhone { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("editedBy")]
        public string EditedBy { get; set; }

        [JsonProperty("editedDate")]
        public string EditedDate { get; set; }
    }

    public class RepresentativeUserDefinedField {

        [JsonProperty("userDefineDefinitionId")]
        public int UserDefineDefinitionId { get; set; }

        [JsonProperty("userDefineDataId")]
        public int UserDefineDataId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("entityId")]
        public int EntityId { get; set; }
    }
}