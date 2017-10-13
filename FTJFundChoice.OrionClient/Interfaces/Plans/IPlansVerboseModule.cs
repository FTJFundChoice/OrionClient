using FTJFundChoice.OrionClient.Models.Enums;
using FTJFundChoice.OrionClient.Models.Portfolio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces.Plans
{
	public interface IPlansVerboseModule
	{
		Task<IResult<IEnumerable<PlanVerbose>>> GetAllAsync(bool? IsActive = false, params PlanExpands[] expands);

		Task<IResult<PlanVerbose>> GetAsync(long id, params PlanExpands[] expands);
	}
}
