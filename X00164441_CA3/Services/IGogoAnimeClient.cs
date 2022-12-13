using System.Net;
using X00164441_CA3.Models;

namespace X00164441_CA3.Services
{
    public interface IGogoAnimeClient
    {
        Task<(HttpStatusCode, PaginatedList<RecentEpisode>?)> GetRecentEpisodes();
        Task<(HttpStatusCode, AnimeInfo?)> GetAnimeInfo(string animeId);
        Task<PaginatedList<SearchResult>?> Search(string query);
    }
}
