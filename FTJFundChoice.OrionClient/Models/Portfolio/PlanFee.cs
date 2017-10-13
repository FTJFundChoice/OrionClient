using Newtonsoft.Json;

namespace FTJFundChoice.OrionClient.Models.Portfolio
{
	public class PlanFee
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("party")]
		public string Party { get; set; }

		[JsonProperty("feePercent")]
		public decimal FeePercent { get; set; }
	}
}
