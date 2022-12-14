using System.Net;
using X00164441_CA3.Models;

namespace X00164441_CA3.Services
{
    public interface IGogoAnimeClient
    {
        Task<PaginatedList<Anime>?> GetTopAiring();
        Task<PaginatedList<RecentEpisode>?> GetRecentEpisodes();
        Task<(HttpStatusCode, AnimeDetails?)> GetAnimeDetails(string animeId);
        Task<PaginatedList<SearchResult>?> SearchAnime(string query);
    }
}
