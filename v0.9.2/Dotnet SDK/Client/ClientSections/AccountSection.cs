using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Account;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client.ClientSections
{
    public class AccountSection
    {
        public async Task<IList<GetAccountIdsResponse>> GetAccountIdsByPhoneNumber(string[] userIdentifiers,
            bool autoCreate)
        {
            try
            {
                var req = new GetAccountIdsInput() { AutoCreate = autoCreate, UserIdentifiers = userIdentifiers };
                var response =
                    await HttpHelper.Post<IList<GetAccountIdsResponse>>(EndpointAddresses.GetAccountIdsByPhoneNumber, req);
                return response;
            }
            catch (Exception e)
            {
                return default(IList<GetAccountIdsResponse>);
            }
        }
    }
}
