using System.Net.Http;

namespace Appson.Identity.Client
{
    public sealed class IdentityClient
    {
        private static readonly HttpClient Http = new HttpClient();

        private readonly Configuration _config;
        internal IdentityClient(Configuration config)
        {
            _config = config;
        }

        public Configuration Reconfigure => Configurator.Configure;
        public string Dump()
        {
            return $"Address: {_config.Address} -- ApplicationId: {_config.ApplicationId}";
        }
    }
}