using FTJFundChoice.OrionClient.Enums;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [Collection("Plan Sponsor Tests")]
    public class PlanSponsorTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var result = await Client.Portfolio.PlanSponsors.GetAllAsync();

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.True(result.Data.Count() > 0);
            Assert.NotNull(result.Data.ToList()[0]);
        }
    }
}