using Newtonsoft.Json;
using System;

namespace FTJFundChoice.OrionModels.Portfolio {

    public class SubAdvisorPortfolio {

        [JsonProperty("blockAccountNumber")]
        public string BlockAccountNumber { get; set; }

        [JsonProperty("saCode")]
        public string SACode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("payeeId")]
        public int PayeeId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("ssN_TaxID")]
        public string SSN_TaxID { get; set; }

        [JsonProperty("strDOB")]
        public string strDOB { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty("editedBy")]
        public string EditedBy { get; set; }

        [JsonProperty("editedDate")]
        public DateTime? EditedDate { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("homePhoneExt")]
        public string HomePhoneExt { get; set; }

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

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("faxExt")]
        public string FaxExt { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("pagerExt")]
        public string PagerExt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("webAddress")]
        public string WebAddress { get; set; }
    }
}