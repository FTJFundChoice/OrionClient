using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace OrionClient.Test.Portfolio {

    [TestClass]
    public class BrokerDealerTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var results = Client.Portfolio.BrokerDealers.GetAll().ToList();

            Assert.IsTrue(results.Count > 0);
            Assert.IsNotNull(results[0].Portfolio.OldBDCode);
        }

        [TestMethod]
        public void Get() {
            var result = Client.Portfolio.BrokerDealers.Get(3);

            Assert.IsNotNull(result.Portfolio.OldBDCode);
        }
    }
}