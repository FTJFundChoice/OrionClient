using System.Configuration;
using System.Threading.Tasks;
using Xunit;

namespace FTJFundChoice.OrionClient.Test.Security {

    [Collection("Security Tests")]
    public class SecurityTests : BaseTest {

        [Fact]
        public async Task GetImpersonationToken() {
            var entity = ConfigurationManager.AppSettings["entity"];
            var entityId = ConfigurationManager.AppSettings["entityId"];

            var result = await Client.Security.GetImpersonationToken(entity, entityId);

            Assert.True(result.Success);
            Assert.False(string.IsNullOrEmpty(result.Content));
        }

        [Fact]
        public async Task GetToken() {
            var username = ConfigurationManager.AppSettings["api_username"];
            var password = ConfigurationManager.AppSettings["api_password"];

            var result = await Client.Security.GetToken(username, password);

            Assert.True(result.Success);
            Assert.False(string.IsNullOrEmpty(result.Content));
        }
    }
}