using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Models.Enums;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Portfolio
{
	[Collection("Plans Tests")]
	public class PlanTests : BaseTest
	{

		[Fact]
		public async Task GetAll()
		{
			var result = await Client.Portfolio.Plans.Verbose.GetAllAsync(true, PlanExpands.All);

			Assert.Equal(result.StatusCode, StatusCode.OK);
			Assert.True(result.Data.Count() > 0);
			Assert.NotNull(result.Data.ToList()[0]);
		}
	}
}
