using System.Collections.Generic;

namespace Appson.Identity.Client.Model.Application.GetApplicationPolicies
{
    public class GetApplicationPoliciesResponse
    {
        public IList<Policy> Policies { get; set; }
        public string TenantIdentifier { get; set; }
    }
}
