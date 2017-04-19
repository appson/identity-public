using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class AuthenticationSectionTests : TestBase
    {
        private async Task StartAuthWithPhone()
        {
            await Client.Authentication.WithPhoneNumber.StartAsync("09378371112");
        }

        [TestMethod]
        public async Task should_start_phone_authentication()
        {
            var response = await Client.Authentication.WithPhoneNumber.StartAsync("09378371112");
            Assert.IsFalse(string.IsNullOrEmpty(response.VerificationId));
        }

        [TestMethod]
        public async Task should_commit_phone_authentication()
        {
            var response = await Client.Authentication.WithPhoneNumber.CommitAsync("89097", "09378371112");
            Assert.IsFalse(string.IsNullOrEmpty(response.IdToken));
        }

        [TestMethod]
        public async Task should_associate_telegramId_to_phone()
        {
            var response =
                await Client.Authentication.WithPhoneNumber.AssociateTelegramIdAsync("11223344", "abcndde",
                    "09378371112");
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public async Task should_associate_sim_information_to_phone()
        {
            var response =
                await Client.Authentication.WithPhoneNumber.AssociateSimInformationAsync("aaaaa", "bbbbbb", "0",
                    "aabbccddee", "09378371112");
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public async Task should_authenticate_by_email()
        {
            var response = await Client.Authentication.WithEmail.AuthenticateAsync("kia@appson.ir", "passw0rd");
            Assert.IsTrue(response != null);
        }
    }
}