using System;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class ConfigurationTests:TestBase
    {
        [TestMethod]
        public void should_return_configured_client()
        {

            Assert.IsNotNull(Client);
        }
    }
}
