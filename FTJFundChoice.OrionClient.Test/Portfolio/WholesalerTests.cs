using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace FTJFundChoice.OrionClient.Test {

    [TestClass]
    public class WholesalerTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var result = Client.Portfolio.Wholesalers.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public void Get() {
            var result = Client.Portfolio.Wholesalers.Get(13);

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(result.Data);
        }
    }
}