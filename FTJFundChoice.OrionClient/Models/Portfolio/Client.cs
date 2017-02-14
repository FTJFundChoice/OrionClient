using FTJFundChoice.OrionClient.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Models.Portfolio {

    public class Client {

        [JsonProperty("aum")]
        public decimal AUM { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("representativeName")]
        public string RepresentativeName { get; set; }

        [JsonProperty("representativeNumber")]
        public string RepresentativeNumber { get; set; }

        [JsonProperty("representativeId")]
        public long RepresentativeId { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("statementDeliveryMethodId")]
        public int StatementDeliveryMethodId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("statementDeliveryMethod")]
        public string StatementDeliveryMethod { get; set; }

        [JsonProperty("videoStatementDeliveryMethod")]
        public VideoStatementMethod VideoStatementDeliveryMethod { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("editedBy")]
        public string EditedBy { get; set; }

        [JsonProperty("editedDate")]
        public DateTime EditedDate { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("importKey")]
        public string ImportKey { get; set; }

        [JsonProperty("lastStatementSent")]
        public DateTime? LastStatementSent { get; set; }

        [JsonProperty("lastStatementSentTo")]
        public string LastStatementSentTo { get; set; }

        [JsonProperty("additionalAccounts")]
        public int AdditionalAccounts { get; set; }

        [JsonProperty("missingInformation")]
        public string MissingInformation { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string state { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("faxExt")]
        public string FaxExt { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("pagerExt")]
        public string pagerExt { get; set; }

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

        [JsonProperty("reportName")]
        public string ReportName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("ssN_TaxID")]
        public string SSN_TaxID { get; set; }

        [JsonProperty("personalId")]
        public int PersonalId { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("additionalColumns")]
        public IEnumerable<AdditionalColumnDefinition> AdditionalColumns { get; set; }

        [JsonProperty("dob")]
        public string DOB { get; set; }

        [JsonProperty("webAddress")]
        public string WebAddress { get; set; }

        [JsonProperty("homePhoneExt")]
        public string HomePhonExt { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("riskScore")]
        public decimal? RiskScore { get; set; }

        [JsonProperty("ccNum")]
        public string CcNum { get; set; }

        [JsonProperty("ccType")]
        public string CcType { get; set; }

        [JsonProperty("ccToken")]
        public string CcToken { get; set; }

        [JsonProperty("ccIsValid")]
        public bool CcIsValid { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}