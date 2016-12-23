using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test.Security {

    [TestClass]
    public class SecurityTests : BaseTest {

        [TestMethod]
        public async Task GetImpersonationToken() {
            var entity = ConfigurationManager.AppSettings["entity"];
            var entityId = ConfigurationManager.AppSettings["entityId"];

            var result = await Client.Security.GetImpersonationToken(entity, entityId);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsFalse(string.IsNullOrEmpty(result.Content));
        }

        [TestMethod]
        public async Task GetToken() {
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];

            var result = await Client.Security.GetToken(username, password);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsFalse(string.IsNullOrEmpty(result.Content));
        }
    }
}