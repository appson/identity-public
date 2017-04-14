using System.Net.Http;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Email;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client.ClientSections
{
    public class EmailSection
    {
        public async Task SendVerificationEmailAsync(string email)
        {
            var req = new SendVerificationEmailInput()
            {
                Email = email
            };
            var response = await HttpHelper.Client.PostAsJsonAsync(EndpointAddresses.EmailSendVerificationEmail, req);

            if (response.IsSuccessStatusCode)
            {
                
            }
        }
    }
}