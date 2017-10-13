using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTJFundChoice.OrionClient.Interfaces.Plans;
using FTJFundChoice.OrionClient.Models.Enums;
using FTJFundChoice.OrionClient.Models.Portfolio;
using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Extensions;

namespace FTJFundChoice.OrionClient.Compositions.Plans
{
	public class PlansVerboseModule : IPlansVerboseModule
	{
		private OrionApiClient client = null;

		public PlansVerboseModule(OrionApiClient client)
		{
			this.client = client;
		}

		public async Task<IResult<IEnumerable<PlanVerbose>>> GetAllAsync(bool? IsActive = false, params PlanExpands[] expands)
		{
			var request = new Request("Portfolio/Plans/Verbose", Method.GET);
			request.AddExpandQueryParameters(Array.ConvertAll<PlanExpands, int>(expands, delegate (PlanExpands value) { return (int)value; }));

			return await client.ExecuteTaskAsync<IEnumerable<PlanVerbose>>(request);
		}

		public async Task<IResult<PlanVerbose>> GetAsync(long id, params PlanExpands[] expands)
		{
			var request = new Request("Portfolio/Plans/Verbose/{id}", Method.GET);
			request.AddUrlSegment("id", Convert.ToString(id));
			request.AddExpandQueryParameters(Array.ConvertAll<PlanExpands, int>(expands, delegate (PlanExpands value) { return (int)value; }));

			return await client.ExecuteTaskAsync<PlanVerbose>(request);
		}
	}
}
