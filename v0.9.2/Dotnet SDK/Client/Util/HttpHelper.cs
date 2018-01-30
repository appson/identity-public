using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appson.Identity.Client.Util
{
    public static class HttpHelper
    {
        private static  HttpClient Client { get; set; }

        public static void Configure(HttpClient httpClient)
        {
            Client = httpClient;
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