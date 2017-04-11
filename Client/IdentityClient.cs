﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Appson.Identity.Client.ClientSections;

namespace Appson.Identity.Client
{
    public class IdentityClient
    {
        private readonly Configuration _config;
        public ApplicationSection Application { get; }
        public AuthenticationSection Authentication { get; }

        internal IdentityClient(Configuration config)
        {
            _config = config;
            SectionBase.Configure(config);
            Application = new ApplicationSection();
            Authentication = new AuthenticationSection();
        }

        internal IdentityClient()
        {
        }

        public string Dump()
        {
            return $"Address: {_config.Address} -- ApplicationId: {_config.ApplicationId}";
        }
    }
}