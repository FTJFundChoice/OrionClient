using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace OrionClient.Test.Portfolio {

    [TestClass]
    public class BrokerDealerTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var result = Client.Portfolio.BrokerDealers.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
            Assert.IsNotNull(result.Data[0].Portfolio.OldBDCode);
        }

        [TestMethod]
        public void Get() {
            var result = Client.Portfolio.BrokerDealers.Get(3);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data.Portfolio.OldBDCode);
        }
    }
}