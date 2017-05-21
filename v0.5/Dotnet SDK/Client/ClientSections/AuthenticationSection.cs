using System;
using System.Threading.Tasks;
using Appson.Identity.Client.Model.Authentication;

namespace Appson.Identity.Client.ClientSections
{
    public class AuthenticationSection : IAuthenticationSection
    {

        public IPhoneAuthenticationSection WithPhoneNumber { get; set; } = new PhoneAuthenticationSection();
        public IEmailAuthenticationSection WithEmail { get; set; } = new EmailAuthenticationSection();
    }
}