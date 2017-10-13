using Newtonsoft.Json;
using System;

namespace FTJFundChoice.OrionClient.Models.Portfolio
{
	public class PlanPersonal
	{
		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("salutation")]
		public string Salutation { get; set; }

		[JsonProperty("address1")]
		public string Address1 { get; set; }

		[JsonProperty("address2")]
		public string Adress2 { get; set; }

		[JsonProperty("address3")]
		public string Address3 { get; set; }

		[JsonProperty("zip")]
		public string Zip { get; set; }

		[JsonProperty("homePhone")]
		public string HomePhone { get; set; }

		[JsonProperty("homePhoneExt")]
		public string HomePhonExt { get; set; }

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

		[JsonProperty("otherPhone")]
		public string OtherPhone { get; set; }

		[JsonProperty("otherPhoneExt")]
		public string OtherPhoneExt { get; set; }

		[JsonProperty("company")]
		public string Company { get; set; }

		[JsonProperty("jobTitle")]
		public string JobTitle { get; set; }

		// TODO Validate this is correct json key
		[JsonProperty("ssn_TaxId")]
		public string SSNTaxId { get; set; }

		[JsonProperty("gender")]
		public string Gender { get; set; }

		[JsonProperty("dob")]
		public DateTime? DOB { get; set; }

		[JsonProperty("webAdress")]
		public string WebAddress { get; set; }
	}
}
