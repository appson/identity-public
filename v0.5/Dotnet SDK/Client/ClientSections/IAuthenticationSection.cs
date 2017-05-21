namespace Appson.Identity.Client.ClientSections
{
    public interface IAuthenticationSection
    {
        IEmailAuthenticationSection WithEmail { get; set; }
        IPhoneAuthenticationSection WithPhoneNumber { get; set; }
    }
}