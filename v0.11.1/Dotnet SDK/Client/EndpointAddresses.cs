namespace Appson.Identity.Client
{
    internal static class EndpointAddresses
    {
        internal static readonly string BaseAddress = "https://accounts.appson.ir/";
        internal static readonly string ApplicationKey = "/api/application/key";
        internal static readonly string AuthenticationPhoneNumberStart = "/api/authentication/phonenumber/start";
        internal static readonly string AuthenticationPhoneNumberCommit = "/api/authentication/phonenumber/commit";

        internal static readonly string AuthenticationAssociateTelegramIdToPhoneNumber =
            "/api/authentication/phonenumber/commit/set/telegramid";

        internal static readonly string AuthenticationAssociateSimInformationToPhoneNumber =
            "/api/authentication/phonenumber/commit/set/siminformation";

        internal static readonly string AuthenticationEmail = "/api/authentication/email";
        internal static readonly string EmailSendVerificationEmail = "/api/email/verificationId/Add";
        internal static readonly string EmailSendResetPasswordEmail = "/api/email/resetpassword/start";
        internal static readonly string EmailCompleteResetPassword = "/api/email/resetpassword/complete";
        internal static readonly string EmailVerifyEmailAddress = "/api/email/activate";
        internal static readonly string EmailChangePassword = "/api/email/changepassword";
        internal static readonly string GetAccountIdsByPhoneNumber = "/api/account/id/get/byphonenumber";
        internal static readonly string GetApplicationPolicies = "api/application/policies/{0}";
    }
}