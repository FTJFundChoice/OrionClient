using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio
{
	public class ParticipantAccount
	{
		[JsonProperty("accountId")]
		public int AccountId { get; set; }

		[JsonProperty("householdId")]
		public int HouseholdId { get; set; }

		[JsonProperty("householdName")]
		public string HouseholdName { get; set; }

		[JsonProperty("accountNumber")]
		public string AccountNumber { get; set; }

		[JsonProperty("fundFamilyName")]
		public string FundFamilyName { get; set; }

		[JsonProperty("managementStyleName")]
		public string ManagementStyleName { get; set; }

		[JsonProperty("householdEmail")]
		public string HouseholdEmail { get; set; }

		[JsonProperty("isActive")]
		public bool IsActive { get; set; }
	}
}
