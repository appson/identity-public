using System;
using System.Threading.Tasks;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class AuthenticationSectionTests : TestBase
    {
        [TestMethod]
        public async Task should_start_phone_authentication()
        {
            var response = await Client.Authentication.WithPhoneNumber.StartAsync("09378371112");
            Assert.IsFalse(string.IsNullOrEmpty(response.VerificationId));
        }

        [TestMethod]
        public async Task should_commit_phone_authentication()
        {
            var response = await Client.Authentication.WithPhoneNumber.CommitAsync("54839", "09378371112");
            Assert.IsFalse(string.IsNullOrEmpty(response.IdToken));
        }
    }
}
