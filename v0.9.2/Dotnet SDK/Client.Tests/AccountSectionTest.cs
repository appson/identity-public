using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Account;

namespace Client.Tests
{
    [TestClass]
    public class AccountSectionTest : TestBase
    {
        [TestMethod]
        public async Task should_get_accountId_by_phoneNumber()
        {
            var response = await Client.Account.GetAccountIdsByPhoneNumber(new[] { "09903024656" }, false);

            Assert.IsFalse(response == null);
            GetAccountIdsResponse first = response.FirstOrDefault();

            Assert.IsTrue(first != null && first.IsValid);

            Assert.IsFalse(string.IsNullOrEmpty(first.Result.AccountId));
        }

        [TestMethod]
        public async Task should_get_two_accountId_by_phoneNumber()
        {
            var responses = await Client.Account.GetAccountIdsByPhoneNumber(new[] { "09903024656", "09903024656" }, false);

            Assert.IsFalse(responses == null);
            foreach (var response in responses)
            {
                Assert.IsTrue(response != null && response.IsValid);
                Assert.IsFalse(string.IsNullOrEmpty(response.Result.AccountId));
            }
            var first = responses.FirstOrDefault();
            var second = responses.LastOrDefault();
            Assert.IsTrue(first?.Result.AccountId == second?.Result.AccountId);
            Assert.IsTrue(first?.Result.UserIdentifier == second?.Result.UserIdentifier);
        }

        [TestMethod]
        public async Task should_not_found_accountId()
        {
            var response = await Client.Account.GetAccountIdsByPhoneNumber(new[] { "999999999a" }, false);

            Assert.IsFalse(response == null);
            GetAccountIdsResponse first = response.FirstOrDefault();
            Assert.IsFalse(first != null && first.IsValid);
            Assert.IsTrue(first != null && first.Result == null);
        }
    }
}
