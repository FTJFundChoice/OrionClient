using FTJFundChoice.OrionClient.Enums;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [Collection("SubAdvisor Tests")]
    public class SubAdvisorTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var result = await Client.Portfolio.SubAdvisors.GetAllAsync();

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.True(result.Data.Count() > 0);
            Assert.NotNull(result.Data.ToList()[0]);
        }

        [Fact]
        public async Task SimpleGetAll() {
            var result = await Client.Portfolio.SubAdvisors.Simple.GetAllAsync();

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.True(result.Data.Count() > 0);
            Assert.NotNull(result.Data.ToList()[0]);
        }
    }
}