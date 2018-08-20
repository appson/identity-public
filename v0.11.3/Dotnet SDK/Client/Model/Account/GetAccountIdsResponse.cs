namespace Appson.Identity.Client.Model.Account
{
    public class GetAccountIdsResponse
    {
        public bool IsValid { get; set; }
        public Result Result { get; set; }

    }

    public class Result
    {
        public string AccountId { get; set; }
        public string UserIdentifier { get; set; }
    }
}
