using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Application.Key;
using ServiceStack;

namespace Appson.Identity.Client.ClientSections
{
    public class ApplicationSectionClient : IdentityClient
    {
        public async Task<ApplicationKeyResponse> GetPublicKey(string applicationId)
        {
            var req = new ApplicationKeyInput { AppId = applicationId };
            var response = await Http.PostAsJsonAsync(EndpointAddresses.ApplicationKey, req);
            var applicationKeyResponse = await response.Content.ReadAsAsync<ApplicationKeyResponse>();
            return applicationKeyResponse;

        }
    }
}