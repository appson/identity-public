using System.Threading.Tasks;
using Appson.Identity.Client.Model.Email;

namespace Appson.Identity.Client.ClientSections
{
    public interface IEmailSection
    {
        Task<SendEmailVerificationResponse> SendVerificationEmailAsync(string email);
    }
}