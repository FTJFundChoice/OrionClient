using FTJFundChoice.OrionClient.Enums;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test {

    [Collection("Wholesaler Tests")]
    public class WholesalerTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var wholeSaler = new Compositions.WholesalersModule(Client);
            var result = await wholeSaler.GetAll();

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task Get() {
            var wholeSaler = new Compositions.WholesalersModule(Client);
            var result = await wholeSaler.Get(13);

            Assert.Equal(result.StatusCode, StatusCode.OK);
            Assert.NotNull(result.Data);
        }
    }
}