using FTJFundChoice.OrionModels.Enums;
using Newtonsoft.Json;
using System;

namespace FTJFundChoice.OrionModels.Portfolio {

    public class BrokerDealerAdditionalContact {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("homePhoneExt")]
        public string HomePhoneExt { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("faxExt")]
        public string FaxExt { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("pagerExt")]
        public string PagerExt { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("businessPhone")]
        public string BusinessPhone { get; set; }

        [JsonProperty("businessPhoneExt")]
        public string BusinessPhoneExt { get; set; }

        [JsonProperty("otherPhone")]
        public string OtherPhone { get; set; }

        [JsonProperty("otherPhoneExt")]
        public string OtherPhoneExt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ssn_TaxId")]
        public string SSN_TaxId { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("dob")]
        public DateTime? DOB { get; set; }

        [JsonProperty("webAddress")]
        public string WebAddress { get; set; }

        [JsonProperty("entityType")]
        public Entity EntityType { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }
    }
}