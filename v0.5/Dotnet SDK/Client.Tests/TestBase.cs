using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class TestBase
    {
        protected virtual IdentityClient Client { get; private set; }
        protected virtual string AppId { get; } = "<sample_app_id>";
        protected virtual string AppIdPublicKey { get; } = "<sample_public_key>";
        protected virtual string ServerAddress { get; } = "http://example.com";

        [TestInitialize]
        public void Init()
        {
            Client = new IdentityClient(AppId, ServerAddress);
        }
    }
}