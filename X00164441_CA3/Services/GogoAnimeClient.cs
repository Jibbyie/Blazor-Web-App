using System.Net;
using System.Net.Http.Json;
using X00164441_CA3.Models;

namespace X00164441_CA3.Services
{
    public class GogoAnimeClient : IGogoAnimeClient
    {
        private readonly HttpClient _client;

        public GogoAnimeClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<PaginatedList<Anime>?> GetTopAiring()
        {
            var response = await _client.GetAsync(GogoAnimeConstants.TopAiringEndpoint);

            if (!response.IsSuccessStatusCode)
            {
                // log error
                return null;
            }

            return await response.Content.ReadFromJsonAsync<PaginatedList<Anime>>();
        }

        public async Task<PaginatedList<RecentEpisode>?> GetRecentEpisodes()
        {
            var response = await _client.GetAsync(GogoAnimeConstants.RecentEpisodesEndpoint);

            if (!response.IsSuccessStatusCode)
            {
                // log error
                return null;
            }

            return await response.Content.ReadFromJsonAsync<PaginatedList<RecentEpisode>>();
        }

        public async Task<(HttpStatusCode, AnimeDetails?)> GetAnimeDetails(string animeId)
        {
            var response = await _client
                .GetAsync(string.Format(GogoAnimeConstants.AnimeInfoEndpoint, animeId));

            if (!response.IsSuccessStatusCode)
            {
                return (response.StatusCode, null);
            }

            return (response.StatusCode,
                await response.Content.ReadFromJsonAsync<AnimeDetails?>());
        }

        public async Task<PaginatedList<SearchResult>?> SearchAnime(string query)
        {
            var response = await _client.GetAsync(string.Format(GogoAnimeConstants.SearchEndpoint, query));

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<PaginatedList<SearchResult>>();
        }
    }
}
