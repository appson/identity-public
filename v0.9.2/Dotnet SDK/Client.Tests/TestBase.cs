using Appson.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests
{
    [TestClass]
    public class TestBase
    {
        protected virtual IdentityClient Client { get; private set; }
        protected virtual string AppId { get; } = "9A01E0FC-2FC0-4741-9811-2EC82F3B49E0";
        protected virtual string AppIdPublicKey { get; } = "<RSAKeyValue><Modulus>wuxQ04syw+jGxm4xt4nNH1CcpEwusQXks3XTSEHeirZop0QZf/8038SPO8iCBtXJNeigAiRzzm72J/E9kOiv3EuIG1FnaCTYKT1MvgXEK5ldkSjHfZUR3zugvz5RNAhBziTl1y4dQMGOQ/lUHImQXmYP1TjzYxtpnKZLIGinwbrxnFuQEmn4Tt73xea4MPV9IZhwTFOjiyudxSas7pr+YH01y4cHHXLrpPhhxGUqzXHMRwmPtR+UuCRcevNSu7iMLQB9/PkZGMbWAFkW/vLmXIM9NyCladHxBxcSple5sitYBAsCbq/C4+06hxlmtu/WqYa+eSidmcfIW1blSO2Auw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        protected virtual string ServerAddress { get; } = "https://accounts-staging.appson.ir";

        [TestInitialize]
        public void Init()
        {
            Client = new IdentityClient(ServerAddress, AppId); 
        }
    }
}