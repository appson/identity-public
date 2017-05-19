using System.Threading.Tasks;
using Appson.Identity.Client.Model.Authentication;

namespace Appson.Identity.Client.ClientSections
{
    public interface IEmailAuthenticationSection
    {
        Task<EmailAuthenticationResponse> AuthenticateAsync(string email, string password);
    }
}