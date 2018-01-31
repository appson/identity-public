using Appson.Identity.Client.ClientSections;
using Appson.Identity.Client.Util;
using System.Net.Http;

namespace Appson.Identity.Client
{
    public class IdentityClient
    {
        public IdentityClient()
        {
            Application = new ApplicationSection();
            Authentication = new AuthenticationSection();
            Account = new AccountSection();
            Email = new EmailSection();
        }

        public IdentityClient(HttpClient httpClient) : this()
        {
            HttpHelper.SetClient(httpClient);
        }

        public IdentityClient(string baseAddress, string applicationId) : this()
        {
            HttpHelper.SetClient(new IdentityClientConfiguration(baseAddress, applicationId));
        }

        public ApplicationSection Application { get; }
        public AuthenticationSection Authentication { get; }
        public EmailSection Email { get; }
        public AccountSection Account { get; }
    }
}