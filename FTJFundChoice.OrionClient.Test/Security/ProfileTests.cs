using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Security {

    [Collection("Profile Tests")]
    public class ProfileTests : BaseTest {

        [Fact]
        public async Task GetAll() {
            var result = await Client.Security.Profiles.GetAll();

            Assert.True(result.Success);
            Assert.NotNull(result.Data);
            Assert.True(result.Data.Count > 0);
        }

        [Fact]
        public async Task Search() {
            var result = await Client.Security.Profiles.Search("testrep@");

            Assert.True(result.Success);
            Assert.True(result.Data.Count > 0);
        }
    }
}