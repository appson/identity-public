namespace Appson.Identity.Client.Model.Account
{
    public class GetAccountIdsInput
    {
        public string[] UserIdentifiers { get; set; }
        public bool AutoCreate { get; set; }
    }
}
