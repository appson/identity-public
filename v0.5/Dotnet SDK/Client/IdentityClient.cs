using System.Net.Http;
using Appson.Identity.Client.ClientSections;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client
{
    public class IdentityClient
    {
        internal IdentityClient(IdentityClientConfiguration config)
        {
            Configuration = config;
            HttpHelper.Configure(config.ApplicationId, config.Address);
            Application = new ApplicationSection();
            Authentication = new AuthenticationSection();
            Email = new EmailSection();
        }

        public IdentityClient(string applicationId, string address = "https://accounts.appson.ir")
            : this(new IdentityClientConfiguration(applicationId, address))
        {
        }

        public ApplicationSection Application { get; }
        public AuthenticationSection Authentication { get; }
        public EmailSection Email { get; }
        public IdentityClientConfiguration Configuration { get; }
    }
}