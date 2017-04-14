using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appson.Identity.Client.Util
{
    public static class HttpHelper
    {
        private static readonly HttpClient Client = new HttpClient();

        [Obsolete("Try using Configure(string applicationId, string address).",true)]
        public static void Configure(IdentityClientConfiguration config)
        {
            Configure(config.ApplicationId,config.Address);
        }

        public static void Configure(string applicationId, string address)
        {
            try
            {
                Client.BaseAddress = new Uri(address);
            }
            catch (Exception e)
            {
                throw new ArgumentException($"{address} is not a valid URI.");
            }
            Client.DefaultRequestHeaders.Add("Appson-Identity-App-Id", applicationId);
        }


        public static async Task<T> Post<T>(string endpoint, object dto)
        {
            var response = await Client.PostAsJsonAsync(endpoint, dto);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<T>();
                return result;
            }

            var error = await response.Content.ReadAsStringAsync();
            throw new Exception(error);
        }
    }
}