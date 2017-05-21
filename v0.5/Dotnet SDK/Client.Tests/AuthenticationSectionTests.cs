
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class AuthenticationSectionTests : TestBase
    {
        [TestMethod]
        public async Task should_start_phone_authentication()
        {
            var response = await Client.Authentication.WithPhoneNumber.StartAsync("<sample_phone>");
            Assert.IsFalse(string.IsNullOrEmpty(response.VerificationId));
        }

        [TestMethod]
        public async Task should_commit_phone_authentication()
        {
            var response = await Client.Authentication.WithPhoneNumber.CommitAsync("<sample_code>", "<sample_phone>");
            Assert.IsFalse(string.IsNullOrEmpty(response.IdToken));
        }

        [TestMethod]
        public async Task should_associate_telegramId_to_phone()
        {
            var response =
                await Client.Authentication.WithPhoneNumber.AssociateTelegramIdAsync("<sample_telegram_id>", "<sample_verification_code>",
                    "<sample_phone>");
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public async Task should_associate_sim_information_to_phone()
        {
            var response =
                await Client.Authentication.WithPhoneNumber.AssociateSimInformationAsync("<sample_subscriber_id>", "<sample_serial_number>", "<sample_type>",
                    "<sample_verification_code>", "<sample_phone>");
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public async Task should_authenticate_by_email()
        {
            var response = await Client.Authentication.WithEmail.AuthenticateAsync("<sample_email>", "<sample_password>");
            Assert.IsTrue(response != null);
        }
    }
}