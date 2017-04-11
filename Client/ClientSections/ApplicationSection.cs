using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Application.Key;
using ServiceStack;

namespace Appson.Identity.Client.ClientSections
{
    public class ApplicationSection : SectionBase
    {
        public async Task<ApplicationKeyResponse> GetPublicKeyAsync(string applicationId)
        {
            try
            {
                var req = new ApplicationKeyInput { AppId = applicationId };
                var result = await Post<ApplicationKeyResponse>(EndpointAddresses.ApplicationKey, req);
                return result;
            }
            catch (Exception)
            {
                return default(ApplicationKeyResponse);
            }

        }
    }
}