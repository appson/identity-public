using System;
using System.Net.Http;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Email;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client.ClientSections
{
    public class EmailSection : IEmailSection
    {
        public async Task<SendEmailVerificationResponse> SendVerificationEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}