using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appson.Identity.Client.Util
{
    public static class HttpHelper
    {
        public static HttpClient Client { get; private set; }

        public static void SetClient(HttpClient httpClient)
        {
            Client = httpClient;
        }

        public static void SetClient(IdentityClientConfiguration identityClientConfiguration)
        {
            Client = new HttpClient { BaseAddress = new Uri(identityClientConfiguration.Address) };
            Client.DefaultRequestHeaders.Add("Appson-Identity-App-Id", identityClientConfiguration.ApplicationId);
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