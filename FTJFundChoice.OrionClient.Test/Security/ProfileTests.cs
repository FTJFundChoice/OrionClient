using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test.Security {

    [TestClass]
    public class ProfileTests : BaseTest {

        [TestMethod]
        public async Task GetAll() {
            var result = await Client.Security.Profiles.GetAll();

            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.Data);
            Assert.IsTrue(result.Data.Count > 0);
        }

        [TestMethod]
        public async Task Search() {
            var result = await Client.Security.Profiles.Search("a&ifinancial"); // testrep@

            Assert.IsTrue(result.Success);
            Assert.IsTrue(result.Data.Count > 0);
        }
    }
}