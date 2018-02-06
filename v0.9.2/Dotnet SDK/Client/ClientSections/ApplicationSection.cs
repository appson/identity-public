using System;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Application.GetApplicationPolicies;
using Appson.Identity.Client.Model.Application.Key;
using Appson.Identity.Client.Util;

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

        public async Task<GetApplicationPoliciesResponse> GetApplicationPoliciesAsync(string appId)
        {
            try
            {
                var result =
                    await HttpHelper.Get<GetApplicationPoliciesResponse>(
                        string.Format(EndpointAddresses.GetApplicationPolicies, appId));

                return result;
            }
            catch (Exception)
            {
                return default(GetApplicationPoliciesResponse);
            }
        }
    }
}