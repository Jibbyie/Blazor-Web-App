using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using X00164441_CA3.Models;

namespace X00164441_CA3.Services
{
    public class GogoAnimeClient : IGogoAnimeClient
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public GogoAnimeClient(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<(HttpStatusCode, AnimeInfo?)> GetAnimeInfo(string animeId)
        {
            var response = await _client
                .GetAsync(string.Format(GogoAnimeConstants.AnimeInfoEndpoint, animeId));

            if (!response.IsSuccessStatusCode)
            {
                return (response.StatusCode, null);
            }

            return (response.StatusCode,
                await response.Content.ReadFromJsonAsync<AnimeInfo?>());
        }

        public async Task<(HttpStatusCode, PaginatedList<RecentEpisode>?)> GetRecentEpisodes()
        {
            var response = await _client.GetAsync(GogoAnimeConstants.RecentEpisodesEndpoint);

            if (!response.IsSuccessStatusCode)
            {
                return (response.StatusCode, null);
            }

            return (response.StatusCode,
                await response.Content.ReadFromJsonAsync<PaginatedList<RecentEpisode>>());
        }

        public async Task<PaginatedList<SearchResult>?> Search(string query)
        {
            var response = await _client.GetAsync(string.Format(GogoAnimeConstants.SearchEndpoint, query));

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<PaginatedList<SearchResult>>();
        }
    }
}
