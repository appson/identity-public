using System;
using System.Net.Http;
using Appson.Identity.Client.ClientSections;
using ServiceStack.Text;

namespace Appson.Identity.Client
{
    public class IdentityClient
    {
        protected static readonly HttpClient Http = new HttpClient();

        private readonly Configuration _config;
        public ApplicationSectionClient Application { get; }
        internal IdentityClient(Configuration config)
        {
            _config = config;

            Http.BaseAddress = new Uri(config.Address);

            Http.DefaultRequestHeaders.Add("Appson-Identity-App-Id", config.ApplicationId);

            Application = new ApplicationSectionClient();
        }

        internal IdentityClient()
        {
        }

        public string Dump()
        {
            return $"Address: {_config.Address} -- ApplicationId: {_config.ApplicationId}";
        }
    }
}