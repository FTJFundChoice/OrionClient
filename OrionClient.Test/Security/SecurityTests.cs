using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Net;

namespace OrionClient.Test.Security {

    [TestClass]
    public class SecurityTests : BaseTest {

        [TestMethod]
        public void GetImpersonationToken() {
            var entity = ConfigurationManager.AppSettings["entity"];
            var entityId = ConfigurationManager.AppSettings["entityId"];

            var result = Client.Security.ImpersonationToken(entity, entityId);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsFalse(string.IsNullOrEmpty(result.Content));
        }
    }
}