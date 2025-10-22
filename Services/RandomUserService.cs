using RetoTecnicoDiegoNoblecilla.Models;
using System.Text.Json;

public class RandomUserService
{
    private readonly HttpClient _httpClient;

    public RandomUserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResponse> GetRandomUsersAsync(int count = 1)
    {
        string url = $"https://randomuser.me/api/?results={count}";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var contentStream = await response.Content.ReadAsStreamAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var apiResponse = await JsonSerializer.DeserializeAsync<ApiResponse>(contentStream, options);
        return apiResponse!;
    }
}
