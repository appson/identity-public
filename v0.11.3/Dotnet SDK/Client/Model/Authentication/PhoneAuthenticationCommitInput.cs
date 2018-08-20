namespace Appson.Identity.Client.Model.Authentication
{
    public class PhoneAuthenticationCommitInput
    {
        public string PhoneNumber { get; set; }
        public string VerificationCode { get; set; }
        public string VerificationId { get; set; }
    }
}