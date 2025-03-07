using BlazorFullstackPortfolio.Models;

namespace BlazorFullstackPortfolio.Services
{
    public class SkillService
    {
        private readonly HttpClient _httpClient;

        public SkillService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Hämta alla Skills
        public async Task<List<Skill>> GetSkillsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Skill>>("api/skills") ?? new List<Skill>();
        }


        // Lägg till en ny Skill
        public async Task<bool> AddSkillAsync(Skill skill)
        {
            var response = await _httpClient.PostAsJsonAsync("api/skills", skill);
            return response.IsSuccessStatusCode;
        }

        // Ta bort en Skill
        public async Task<bool> DeleteSkillAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/skills/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
