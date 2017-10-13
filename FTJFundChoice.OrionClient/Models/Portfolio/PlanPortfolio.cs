using Newtonsoft.Json;
using System;

namespace FTJFundChoice.OrionClient.Models.Portfolio
{
	public class PlanPortfolio
	{
		[JsonProperty("planName")]
		public string PlanName { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("value")]
		public decimal? Value { get; set; }

		[JsonProperty("isFundWindow")]
		public bool IsFundWindow { get; set; }

		[JsonProperty("planNumber")]
		public string PlanNumber { get; set; }

		[JsonProperty("trustee")]
		public string Trustee { get; set; }

		[JsonProperty("planAdministratorId")]
		public int? PlanAdministratorId { get; set; }

		[JsonProperty("notes")]
		public string Notes { get; set; }

		[JsonProperty("createdBy")]
		public string CreatedBy { get; set; }

		[JsonProperty("createdDate")]
		public DateTime CreatedDate { get; set; }

		[JsonProperty("editedBy")]
		public string EditedBy { get; set; }

		[JsonProperty("editedDate")]
		public DateTime EditedDate { get; set; }

		[JsonProperty("shareClassId")]
		public int? ShareClassId { get; set; }

		[JsonProperty("registrationTypeId")]
		public int? RegistrationTypeId { get; set; }

		[JsonProperty("custodianId")]
		public int? CustodianId { get; set; }
	}
}
