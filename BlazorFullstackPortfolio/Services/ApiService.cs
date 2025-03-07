using BlazorFullstackPortfolio.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorFullstackPortfolio.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Api?> GetApi()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Api>("https://api.chucknorris.io/jokes/random");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching API: {ex.Message}");
                return null;
            }
        }
    }
}
