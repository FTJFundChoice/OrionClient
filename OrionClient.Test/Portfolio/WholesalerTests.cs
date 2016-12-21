using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace OrionClient.Test {

    [TestClass]
    public class WholesalerTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var results = Client.Portfolio.Wholesalers.GetAll().ToList();

            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void Get() {
            var result = Client.Portfolio.Wholesalers.Get(13);

            Assert.IsNotNull(result);
        }
    }
}