using System;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void ClientInstancePropertiesAreSetCorrectly()
        {
            var a = new IdentityClient("my-app-id", "https://accounts-staging.appson.ir");

            Assert.IsNotNull(a);
            Assert.IsTrue(a.Address.Equals("https://accounts-staging.appson.ir",
                StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(
                a.ApplicationId.Equals("my-app-id", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}