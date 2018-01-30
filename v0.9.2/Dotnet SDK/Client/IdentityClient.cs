﻿using System.Net.Http;
using Appson.Identity.Client.ClientSections;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client
{
    public class IdentityClient
    {

        public IdentityClient(HttpClient httpClient)
            
        {
            HttpHelper.Configure(httpClient);
            Application = new ApplicationSection();
            Authentication = new AuthenticationSection();
            Account = new AccountSection();
            Email = new EmailSection();
        }

        public ApplicationSection Application { get; }
        public AuthenticationSection Authentication { get; }
        public EmailSection Email { get; }
        public AccountSection Account { get; set; }
    }
}