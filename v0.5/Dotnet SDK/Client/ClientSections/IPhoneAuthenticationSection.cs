using System.Threading.Tasks;
using Appson.Identity.Client.Model.Authentication;

namespace Appson.Identity.Client.ClientSections
{
    public interface IPhoneAuthenticationSection
    {
        Task<PhoneAuthenticationSetSimInformationResponse> AssociateSimInformationAsync(string subscriberId, string serialNumber, string type, string verificationCode, string phoneNumber = null, string verificationId = null);
        Task<PhoneAuthenticationSetTelegramIdResponse> AssociateTelegramIdAsync(string telegramId, string verificationCode, string phoneNumber = null, string verificationId = null);
        Task<PhoneAuthenticationCommitResponse> CommitAsync(string verificationCode, string phoneNumber = null, string verificationId = null);
        Task<PhoneAuthenticationStartResponse> StartAsync(string phoneNumber, bool alreadyExists = false);
    }
}