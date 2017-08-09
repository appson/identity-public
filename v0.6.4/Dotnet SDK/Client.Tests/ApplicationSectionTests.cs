using System;
using System.Threading.Tasks;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class ApplicationSectionTests : TestBase
    {
        [TestMethod]
        public async Task should_get_public_key_by_appId()
        {
            var response = await Client.Application.GetPublicKeyAsync(AppId);

            Assert.IsFalse(response == null);
            Assert.IsFalse(string.IsNullOrEmpty(response.PublicKey));
            Assert.IsTrue(response.PublicKey.Equals(AppIdPublicKey, StringComparison.InvariantCulture));
        }
    }
}
