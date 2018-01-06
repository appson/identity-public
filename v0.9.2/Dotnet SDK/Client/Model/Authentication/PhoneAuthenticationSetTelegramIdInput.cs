namespace Appson.Identity.Client.Model.Authentication
{
    public class PhoneAuthenticationSetTelegramIdInput
    {
        public string PhoneNumber { get; set; }
        public string VerificationCode { get; set; }
        public string VerificationId { get; set; }
        public string TelegramId { get; set; }
    }
}