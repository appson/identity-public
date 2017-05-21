using Appson.Identity.Client.ClientSections;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client
{
    public class IdentityClient
    {
        public IdentityClient(string applicationId, string address = "https://accounts.appson.ir")
        {
            Address = address;
            ApplicationId = applicationId;
            HttpHelper.Configure(ApplicationId, Address);

            Application = new ApplicationSection();
            Authentication = new AuthenticationSection();
            Email = new EmailSection();
        }

        public ApplicationSection Application { get; }
        public AuthenticationSection Authentication { get; }
        public EmailSection Email { get; }
        public string Address { get; }
        public string ApplicationId { get; }
    }
}