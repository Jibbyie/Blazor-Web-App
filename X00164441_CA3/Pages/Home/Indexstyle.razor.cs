using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Net;
using X00164441_CA3.Models;
using X00164441_CA3.Services;

namespace X00164441_CA3.Pages.Home
{
    public class IndexBase : ComponentBase
    {
        protected PaginatedList<RecentEpisode> PaginatedList { get; set; } = new();
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
            var (statusCode, list) = await Client.GetRecentEpisodes();

            if (statusCode != HttpStatusCode.OK)
                Snackbar.Add(statusCode.ToString(), Severity.Error);
            else
                PaginatedList = list!;
        }

        protected async Task SearchAnimes()
        {
            if (!string.IsNullOrEmpty(SearchQuery))
            {
                SearchList = await Client.Search(SearchQuery);
            }
        }
    }
}
