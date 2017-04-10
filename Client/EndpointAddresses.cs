namespace Appson.Identity.Client
{
    internal static class EndpointAddresses
    {
        internal const string ApplicationKey = "/api/application/key";
        internal const string AuthenticationPhoneNumberStart = "/api/authentication/phonenumber/start";
        internal const string AuthenticationPhoneNumberCommit = "/api/authentication/phonenumber/commit";
        internal const string AuthenticationAssociateTelegramIdToPhoneNumber = "/api/authentication/phonenumber/commit/set/telegramid";
        internal const string AuthenticationAssociateSimInformationToPhoneNumber = "/api/authentication/phonenumber/commit/set/siminformation";
        internal const string AuthenticationEmail = "/api/authentication/email";
    }
}