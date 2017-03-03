using FTJFundChoice.OrionClient.Enums;
using FTJFundChoice.OrionClient.Models.Security;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Trading
{
    [Collection(@"Sleeve Strategy Tests")]
    public class SleeveStrategyTests : BaseTest
    {
        [Fact]
        public async Task GetSleeveStrategy()
        {
            var result = await Client.Trading.SleeveStrategies.GetSleeveStrategyVerboseByRepIdAsync(9365);
            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }

    }
}
