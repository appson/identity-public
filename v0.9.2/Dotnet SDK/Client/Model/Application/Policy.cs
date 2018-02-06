using System.Collections.Generic;
using System.Net;

namespace Appson.Identity.Client.Model.Application
{
    public class Policy
    {
        public string Version { get; set; }
        public ClientCertificate Certificate { get; set; }
        public IList<IPAddress> ValidIps { get; set; }
    }
}
