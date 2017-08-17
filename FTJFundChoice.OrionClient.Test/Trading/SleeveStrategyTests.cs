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
        [Theory]
        [InlineData(9365)]
        [InlineData(10555)]
        public async Task GetVerboseSleeveStrategy(int entityId)
        {
            var result = await Client.Trading.SleeveStrategies.GetSleeveStrategyVerboseByRepIdAsync(entityId);
            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }

        [Theory]
        [InlineData(9365)]
        [InlineData(10555)]
        public async Task GetVerboseAndExpandedSleeveStrategy(int entityId)
        {
            var result = await Client.Trading.SleeveStrategies.GetSleeveStrategyExpandedVerboseByRepIdAsync(entityId);
            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }

    }
}
