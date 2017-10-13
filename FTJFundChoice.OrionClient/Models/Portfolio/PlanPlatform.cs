using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio
{
	public class PlanPlatform
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("platformId")]
		public int PlatformId { get; set; }

		[JsonProperty("platformName")]
		public string PlatformName { get; set; }

		[JsonProperty("feePercent")]
		public decimal FeePercent { get; set; }

		[JsonProperty("feeScheduleId")]
		public int FeeScheduleId { get; set; }

		[JsonProperty("feeScheduleName")]
		public string FeeScheduleName { get; set; }
	}
}
