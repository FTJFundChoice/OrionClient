using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test.Security {

    [TestClass]
    public class SecurityTests : BaseTest {

        [TestMethod]
        public async Task GetImpersonationToken() {
            var entity = ConfigurationManager.AppSettings["entity"];
            var entityId = ConfigurationManager.AppSettings["entityId"];

            var result = await Client.Security.GetImpersonationToken(entity, entityId);

            Assert.IsTrue(result.Success);
            Assert.IsFalse(string.IsNullOrEmpty(result.Content));
        }

        [TestMethod]
        public async Task GetToken() {
            var username = ConfigurationManager.AppSettings["api_username"];
            var password = ConfigurationManager.AppSettings["api_password"];

            var result = await Client.Security.GetToken(username, password);

            Assert.IsTrue(result.Success);
            Assert.IsFalse(string.IsNullOrEmpty(result.Content));
        }
    }
}