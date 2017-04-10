using System;
using System.Threading.Tasks;
using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class ClientTests
    {
        private IdentityClient _client;

        private const string AppId = "9A01E0FC-2FC0-4741-9811-2EC82F3B49E0";
        private const string AppIdPublicKey = "<RSAKeyValue><Modulus>wuxQ04syw+jGxm4xt4nNH1CcpEwusQXks3XTSEHeirZop0QZf/8038SPO8iCBtXJNeigAiRzzm72J/E9kOiv3EuIG1FnaCTYKT1MvgXEK5ldkSjHfZUR3zugvz5RNAhBziTl1y4dQMGOQ/lUHImQXmYP1TjzYxtpnKZLIGinwbrxnFuQEmn4Tt73xea4MPV9IZhwTFOjiyudxSas7pr+YH01y4cHHXLrpPhhxGUqzXHMRwmPtR+UuCRcevNSu7iMLQB9/PkZGMbWAFkW/vLmXIM9NyCladHxBxcSple5sitYBAsCbq/C4+06hxlmtu/WqYa+eSidmcfIW1blSO2Auw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        [TestInitialize]
        public void Init()
        {
            _client = Configurator.Configure
                .WithAddress("https://accounts-staging.appson.ir")
                .WithApplicationId(AppId)
                .Build();
        }

        [TestMethod]
        public async Task should_get_public_key_by_appId()
        {
            var response = await _client.Application.GetPublicKey(AppId);

            Assert.IsFalse(response == null);
            Assert.IsFalse(string.IsNullOrEmpty(response.PublicKey));
            Assert.IsTrue(response.PublicKey.Equals(AppIdPublicKey, StringComparison.InvariantCulture));
        }
    }
}
