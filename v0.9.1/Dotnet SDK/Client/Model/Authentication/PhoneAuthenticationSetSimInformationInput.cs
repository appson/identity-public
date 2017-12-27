namespace Appson.Identity.Client.Model.Authentication
{
    public class PhoneAuthenticationSetSimInformationInput
    {
        public string PhoneNumber { get; set; }
        public string VerificationCode { get; set; }
        public string VerificationId { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public string SubscriberId { get; set; }
    }
}