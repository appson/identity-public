using System;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void should_return_configured_client()
        {
            var a = new IdentityClient("my-app-id", "https://accounts-staging.appson.ir");

            Assert.IsNotNull(a);
            Assert.IsTrue(a.Configuration.Address.Equals("https://accounts-staging.appson.ir", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(a.Configuration.ApplicationId.Equals("my-app-id", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
