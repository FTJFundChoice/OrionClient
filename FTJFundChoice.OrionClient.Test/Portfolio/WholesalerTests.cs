using FTJFundChoice.OrionClient.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test {

    [TestClass]
    public class WholesalerTests : BaseTest {

        [TestMethod]
        public async Task GetAll() {
            var result = await Client.Portfolio.Wholesalers.GetAll();

            Assert.AreEqual(result.StatusCode, StatusCode.OK);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public async Task Get() {
            var result = await Client.Portfolio.Wholesalers.Get(13);

            Assert.AreEqual(result.StatusCode, StatusCode.OK);
            Assert.IsNotNull(result.Data);
        }
    }
}