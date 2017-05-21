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
            const string appId = "<sample_app_id>";
            const string serverAddress = "http://sample.server.tld";

            var client = new IdentityClient(appId, serverAddress);

            Assert.IsNotNull(client);
            Assert.IsTrue(client.Address.Equals(serverAddress, StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(client.ApplicationId.Equals(appId, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}