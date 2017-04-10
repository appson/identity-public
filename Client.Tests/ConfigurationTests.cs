using System;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void should_configure_endpoints_address()
        {
            var a = Configurator.Configure.WithAddress(() => "localhost");
            Assert.IsTrue(a.Address.Equals("localhost", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void should_configure_endpoints_appId()
        {
            var a = Configurator.Configure.WithApplicationId(() => "Sample-App-Id");
            Assert.IsTrue(a.ApplicationId.Equals("Sample-App-Id", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void should_configure_endpoints_address_and_appId()
        {
            var a = Configurator.Configure.WithAddress("localhost").WithApplicationId("my-app-id");
            Assert.IsTrue(a.Address.Equals("localhost", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(a.ApplicationId.Equals("my-app-id", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void should_return_configured_client()
        {
            var a = Configurator.Configure
                .WithAddress("localhost")
                .WithApplicationId("my-app-id")
                .Build();
            Assert.IsNotNull(a);
            var dump = a.Dump();
            Assert.IsTrue(dump.Equals("Address: localhost -- ApplicationId: my-app-id", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void should_reconfigure_endpoint()
        {
            var a = Configurator.Configure
                .WithAddress("localhost")
                .WithApplicationId("my-app-id")
                .Build();
            Assert.IsNotNull(a);

            var dump = a.Dump();
            Assert.IsTrue(dump.Equals("Address: localhost -- ApplicationId: my-app-id", StringComparison.InvariantCultureIgnoreCase));

            a.Reconfigure
                .WithAddress("address2")
                .WithApplicationId("appid2")
                .Build();

            dump = a.Dump();
            Assert.IsTrue(dump.Equals("Address: address2 -- ApplicationId: appid2", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
