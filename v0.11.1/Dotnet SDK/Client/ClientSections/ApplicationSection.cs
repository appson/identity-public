using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Appson.Common.General.Validation;
using Appson.Identity.Client.Exceptions;
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
            var apiResponse =
                await HttpHelper.Client.GetAsync(
                    string.Format(EndpointAddresses.GetApplicationPolicies, appId));

            var result = await apiResponse.Content.ReadAsAsync<ApiValidatedResult<GetApplicationPoliciesResponse>>();

            if (result == null)
                throw new Exception();

            if (!result.Success && result.Errors.Any() && result.Errors.Select(a => a.ErrorKey).Contains("INVALID_APP_ID"))
            {
                throw new InvalidAppIdException(result);
            }

            return result.Result;
        }
    }
}