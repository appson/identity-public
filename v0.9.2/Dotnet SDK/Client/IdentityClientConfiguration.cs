namespace Appson.Identity.Client
{
    public class IdentityClientConfiguration
    {
        public string Address { get; }
        public string ApplicationId { get; }

        internal IdentityClientConfiguration( string address, string applicationId)
        {
            ApplicationId = applicationId;
            Address = address;
        }
    }
}