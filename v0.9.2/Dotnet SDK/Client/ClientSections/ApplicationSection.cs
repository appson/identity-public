using Appson.Identity.Client.Model.Application.Key;
using Appson.Identity.Client.Util;
using System;
using System.Threading.Tasks;

namespace Appson.Identity.Client.ClientSections
{
    public class ApplicationSection
    {
        public async Task<ApplicationKeyResponse> GetPublicKeyAsync(string applicationId)
        {
            try
            {
                var req = new ApplicationKeyInput { AppId = applicationId };
                var result = await HttpHelper.Post<ApplicationKeyResponse>(EndpointAddresses.ApplicationKey, req);
                return result;
            }
            catch (Exception)
            {
                return default(ApplicationKeyResponse);
            }

        }
    }
}