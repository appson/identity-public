namespace Appson.Identity.Client.Model.Authentication
{
    public class PhoneAuthenticationStartInput
    {
        public string PhoneNumber { get; set; }
        public bool AlreadyExists { get; set; } = false;
    }
}