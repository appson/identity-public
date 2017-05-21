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

        public IApplicationSection Application { get; set; }
        public IAuthenticationSection Authentication { get; set; }
        public IEmailSection Email { get; set; }
        public string Address { get; }
        public string ApplicationId { get; }
    }
}