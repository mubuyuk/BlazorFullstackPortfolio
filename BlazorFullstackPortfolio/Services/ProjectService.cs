using BlazorFullstackPortfolio.Models;

namespace BlazorFullstackPortfolio.Services
{
    public class ProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Hämta alla Projects
        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Project>>("api/projects") ?? new List<Project>();
        }
        // Lägg till ett nytt Project
        public async Task<bool> AddProjectAsync(Project project)
        {
            var response = await _httpClient.PostAsJsonAsync("api/projects", project);
            return response.IsSuccessStatusCode;
        }

        // Uppdatera ett Project
        public async Task<bool> UpdateProjectAsync(Project project)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/projects/{project.Id}", project);
            return response.IsSuccessStatusCode;
        }

        // Ta bort ett Project
        public async Task<bool> DeleteProjectAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/projects/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
