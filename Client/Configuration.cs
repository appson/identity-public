using System;

namespace Appson.Identity.Client
{
    public class Configuration
    {
        private IdentityClient _identityClient;
        public string Address { get; private set; }
        public string ApplicationId { get; private set; }

        #region Address Configuration
        public Configuration WithAddress(string address)
        {
            Address = address;
            return this;
        }
        public Configuration WithAddress(Func<string> addressDelegate)
        {
            return WithAddress(addressDelegate.Invoke());
        }
        #endregion

        #region Application Id Configuration
        public Configuration WithApplicationId(string applicationId)
        {
            ApplicationId = applicationId;
            return this;
        }
        public Configuration WithApplicationId(Func<string> applicationIdDelegate)
        {
            return WithApplicationId(applicationIdDelegate.Invoke());
        } 
        #endregion

        public IdentityClient Build()
        {
            return _identityClient ?? (_identityClient = new IdentityClient(this));
        }
    }
}