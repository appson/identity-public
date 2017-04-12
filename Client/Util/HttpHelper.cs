using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appson.Identity.Client.Util
{
    public static class HttpHelper
    {
        private static readonly HttpClient Client = new HttpClient();

        public static void Configure(Configuration config)
        {
            Client.BaseAddress = new Uri(config.Address);
            Client.DefaultRequestHeaders.Add("Appson-Identity-App-Id", config.ApplicationId);
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