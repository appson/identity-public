using System;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Authentication;

namespace Appson.Identity.Client.ClientSections
{
    public class AuthenticationSection
    {

        public PhoneAuthenticationSection WithPhoneNumber => new PhoneAuthenticationSection();
        public EmailAuthenticationSection WithEmail => new EmailAuthenticationSection();
    }
}