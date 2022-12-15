using Microsoft.AspNetCore.Components;
using MudBlazor;
using X00164441_CA3.Models;
using X00164441_CA3.Services;

namespace X00164441_CA3.Pages.Home
{
    public class IndexBase : ComponentBase
    {
        protected PaginatedList<RecentEpisode>? RecentEpisodes { get; set; } = new();
        protected PaginatedList<Models.Anime>? TopAiring { get; set; } = new();
        protected PaginatedList<SearchResult>? SearchList { get; set; } = null;

        protected string? SearchQuery { get; set; }

        [Inject]
        protected IGogoAnimeClient Client { get; set; } = null!;

        [Inject]
        protected ISnackbar Snackbar { get; set; } = null!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = null!;

        protected override async Task OnInitializedAsync()
        {
            TopAiring = await Client.GetTopAiring();
            RecentEpisodes = await Client.GetRecentEpisodes();
        }

        protected async Task SearchAnimes()
        {
            if (!string.IsNullOrEmpty(SearchQuery))
            {
                SearchList = await Client.SearchAnime(SearchQuery);
            }
        }
    }
}
