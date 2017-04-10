using System;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestInitialize]
        public void Init()
        {
            Configurator.Configure
                .WithAddress("https://accounts-staging.appson.ir/")
                .WithApplicationId("9A01E0FC-2FC0-4741-9811-2EC82F3B49E0");
        }
    }
}
