namespace Appson.Identity.Client.ClientSections
{
    public interface IAuthenticationSection
    {
        EmailAuthenticationSection WithEmail { get; }
        PhoneAuthenticationSection WithPhoneNumber { get; }
    }
}