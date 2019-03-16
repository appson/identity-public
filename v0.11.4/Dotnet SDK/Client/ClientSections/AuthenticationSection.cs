namespace Appson.Identity.Client.ClientSections
{
    public class AuthenticationSection
    {
        public PhoneAuthenticationSection WithPhoneNumber => new PhoneAuthenticationSection();
        public EmailAuthenticationSection WithEmail => new EmailAuthenticationSection();
    }
}