using System;
using System.Threading.Tasks;
using Appson.Identity.Client.ClientSections;
using Appson.Identity.Client.Model.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Client.Tests
{
    [TestClass]
    public class AuthenticationSectionTests : TestBase
    {
        [TestMethod]
        public async Task PhoneAuthenticationStartCalledAndVerificationIdReturned()
        {
            var phoneAuthenticationMock = new Mock<IPhoneAuthenticationSection>();
            phoneAuthenticationMock
                .Setup(a => a.StartAsync(It.IsAny<string>(), It.IsAny<bool>()))
                .ReturnsAsync(new PhoneAuthenticationStartResponse {VerificationId = "<sample_verification_id>"});


            var authenticationSectionMock = new Mock<IAuthenticationSection>();
            authenticationSectionMock.Setup(x => x.WithPhoneNumber).Returns(phoneAuthenticationMock.Object);

            Client.Authentication = authenticationSectionMock.Object;

            var response = await Client.Authentication.WithPhoneNumber.StartAsync("<sample_phone>");

            Assert.IsTrue(string.Equals("<sample_verification_id>", response.VerificationId,
                StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public async Task PhoneAuthenticationCommitCalledAndTokenIdReturned()
        {
            var phoneAuthenticationMock = new Mock<IPhoneAuthenticationSection>();
            phoneAuthenticationMock
                .Setup(a => a.CommitAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new PhoneAuthenticationCommitResponse {IdToken = "<sample_token>"});


            var authenticationSectionMock = new Mock<IAuthenticationSection>();
            authenticationSectionMock.Setup(x => x.WithPhoneNumber).Returns(phoneAuthenticationMock.Object);

            Client.Authentication = authenticationSectionMock.Object;

            var response = await Client.Authentication.WithPhoneNumber.CommitAsync("<sample_code>", "<sample_phone>");

            Assert.IsTrue(string.Equals("<sample_token>", response.IdToken, StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public async Task should_associate_telegramId_to_phone()
        {
            var response =
                await Client.Authentication.WithPhoneNumber.AssociateTelegramIdAsync("<sample_telegram_id>",
                    "<sample_verification_code>",
                    "<sample_phone>");
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public async Task should_associate_sim_information_to_phone()
        {
            var response =
                await Client.Authentication.WithPhoneNumber.AssociateSimInformationAsync("<sample_subscriber_id>",
                    "<sample_serial_number>", "<sample_type>",
                    "<sample_verification_code>", "<sample_phone>");
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public async Task should_authenticate_by_email()
        {
            var response =
                await Client.Authentication.WithEmail.AuthenticateAsync("<sample_email>", "<sample_password>");
            Assert.IsTrue(response != null);
        }
    }
}