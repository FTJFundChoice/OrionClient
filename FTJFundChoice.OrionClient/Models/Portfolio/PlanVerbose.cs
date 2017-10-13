using Newtonsoft.Json;
using System.Collections.Generic;

namespace FTJFundChoice.OrionClient.Models.Portfolio
{
	public class PlanVerbose
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("portfolio")]
		public PlanPortfolio Portfolio { get; set; }

		[JsonProperty("personal")]
		public PlanPersonal Personal { get; set; }

		[JsonProperty("sponsor")]
		public PlanSponsor Sponsor { get; set; }

		[JsonProperty("participants")]
		public List<ParticipantAccount> Participants { get; set; }

		[JsonProperty("fees")]
		public List<PlanFee> Fees { get; set; }

		[JsonProperty("platforms")]
		public List<PlanPlatform> Platforms { get; set; }

		[JsonProperty("representatives")]
		public List<RepresentativeSimple> Representatives { get; set; }
	}
}
