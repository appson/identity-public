using System;

namespace Appson.Identity.Client
{
    public class IdentityClientConfiguration
    {
        public string Address { get; }
        public string ApplicationId { get; }

        internal IdentityClientConfiguration(string applicationId, string address)
        {
            ApplicationId = applicationId;
            Address = address;
        }
    }
}