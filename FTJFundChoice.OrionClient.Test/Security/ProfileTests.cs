using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace FTJFundChoice.OrionClient.Test.Security {

    [TestClass]
    public class ProfileTests : BaseTest {

        [TestMethod]
        public void GetAll() {
            var result = Client.Security.Profiles.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
        }

        [TestMethod]
        public void Search() {
            var result = Client.Security.Profiles.Search("testrep@");

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
        }
    }
}