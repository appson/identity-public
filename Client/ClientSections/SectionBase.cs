using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appson.Identity.Client.ClientSections
{
    public class SectionBase
    {
        internal static void Configure(Configuration config)
        {
            Http.BaseAddress = new Uri(config.Address);
            Http.DefaultRequestHeaders.Add("Appson-Identity-App-Id", config.ApplicationId);
        }

        protected static readonly HttpClient Http = new HttpClient();
        protected async Task<T> Post<T>(string endpoint, object dto)
        {
            var response = await Http.PostAsJsonAsync(endpoint, dto);

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