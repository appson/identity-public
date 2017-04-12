using System;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Authentication;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client.ClientSections
{
    public class PhoneAuthenticationSection
    {
        public async Task<PhoneAuthenticationStartResponse> StartAsync(string phoneNumber,
            bool alreadyExists = false)
        {
            try
            {
                var req = new PhoneAuthenticationStartInput { AlreadyExists = alreadyExists, PhoneNumber = phoneNumber };
                var response =
                    await HttpHelper.Post<PhoneAuthenticationStartResponse>(EndpointAddresses.AuthenticationPhoneNumberStart, req);
                return response;
            }
            catch (Exception)
            {
                return default(PhoneAuthenticationStartResponse);
            }
        }

        public async Task<PhoneAuthenticationCommitResponse> CommitAsync(string verificationCode,
            string phoneNumber = null,
            string verificationId = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phoneNumber) && string.IsNullOrWhiteSpace(verificationCode))
                {
                    throw new ArgumentException(
                        "either one of 'phoneNumber' or 'verificationId' arguments must be provided");
                }
                var req = new PhoneAuthenticationCommitInput
                {
                    PhoneNumber = phoneNumber,
                    VerificationCode = verificationCode,
                    VerificationId = verificationId
                };
                var response =
                    await HttpHelper.Post<PhoneAuthenticationCommitResponse>(EndpointAddresses.AuthenticationPhoneNumberCommit,
                        req);
                return response;
            }
            catch (Exception)
            {
                return default(PhoneAuthenticationCommitResponse);
            }
        }

        public async Task<PhoneAuthenticationSetTelegramIdResponse> AssociateTelegramIdAsync(string telegramId,
            string verificationCode, string phoneNumber = null, string verificationId = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phoneNumber) && string.IsNullOrWhiteSpace(verificationCode))
                {
                    throw new ArgumentException(
                        "either one of 'phoneNumber' or 'verificationId' arguments must be provided");
                }

                var req = new PhoneAuthenticationSetTelegramIdInput
                {
                    PhoneNumber = phoneNumber,
                    VerificationId = verificationId,
                    VerificationCode = verificationCode,
                    TelegramId = telegramId
                };

                var response = await
                    HttpHelper.Post<PhoneAuthenticationSetTelegramIdResponse>(
                        EndpointAddresses.AuthenticationAssociateTelegramIdToPhoneNumber, req);
                return response;
            }
            catch (Exception)
            {
                return default(PhoneAuthenticationSetTelegramIdResponse);
            }
        }

        public async Task<PhoneAuthenticationSetSimInformationResponse> AssociateSimInformationAsync(string subscriberId,
            string serialNumber, string type,
            string verificationCode, string phoneNumber = null, string verificationId = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phoneNumber) && string.IsNullOrWhiteSpace(verificationCode))
                {
                    throw new ArgumentException(
                        "either one of 'phoneNumber' or 'verificationId' arguments must be provided");
                }

                var req = new PhoneAuthenticationSetSimInformationInput
                {
                    PhoneNumber = phoneNumber,
                    VerificationId = verificationId,
                    VerificationCode = verificationCode,
                    SerialNumber = serialNumber,
                    SubscriberId = subscriberId,
                    Type = type
                };

                var response = await
                    HttpHelper.Post<PhoneAuthenticationSetSimInformationResponse>(
                        EndpointAddresses.AuthenticationAssociateSimInformationToPhoneNumber, req);
                return response;
            }
            catch (Exception)
            {
                return default(PhoneAuthenticationSetSimInformationResponse);
            }
        }
    }
}