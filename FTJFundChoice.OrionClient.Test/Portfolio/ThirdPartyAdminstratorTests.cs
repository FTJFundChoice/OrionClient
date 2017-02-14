using FTJFundChoice.OrionClient.Enums;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Portfolio {

    [Collection("Third-Party Administrators")]
    public class ThirdPartyAdminstratorTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var result = await Client.Portfolio.ThirdPartyAdministrators.GetAllAsync();

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.True(result.Data.Count > 0);
            Assert.NotNull(result.Data[0]);
        }
    }
}