using System;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Authentication;

namespace Appson.Identity.Client.ClientSections
{
    public class EmailAuthenticationSection : SectionBase
    {
        public async Task<EmailAuthenticationResponse> AuthenticateAsync(string email,
            string password)
        {
            try
            {
                var req = new EmailAuthenticationInput { Email = email, Password = password };
                var response =
                    await Post<EmailAuthenticationResponse>(EndpointAddresses.AuthenticationEmail, req);
                return response;
            }
            catch (Exception)
            {
                return default(EmailAuthenticationResponse);
            }
        }
    }
}