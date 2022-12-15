using MudBlazor.Services;
using System.Net;
using X00164441_CA3;
using X00164441_CA3.Models;
using X00164441_CA3.Services;

namespace UnitTests
{
    public class UnitTest1
    {
        public interface IHttpHandler
        {
            HttpResponseMessage Get(string url);
            HttpResponseMessage Post(string url, HttpContent content);
            Task<HttpResponseMessage> GetAsync(string url);
            Task<HttpResponseMessage> PostAsync(string url, HttpContent content);
        }


        public class HttpClientHandler : IHttpHandler
        {
            private HttpClient _client = new HttpClient();

            public HttpResponseMessage Get(string url)
            {
                return GetAsync(url).Result;
            }

            public HttpResponseMessage Post(string url, HttpContent content)
            {
                return PostAsync(url, content).Result;
            }

            public async Task<HttpResponseMessage> GetAsync(string url)
            {
                return await _client.GetAsync(url);
            }

            public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
            {
                return await _client.PostAsync(url, content);
            }
        }

        private readonly IGogoAnimeClient _anime;

        private readonly HttpClient _client;


        public UnitTest1()
        {   
            _client = new HttpClient();
            _client.BaseAddress = new Uri(GogoAnimeConstants.BaseAddress);
            _anime = new GogoAnimeClient(_client);
        }


        [Fact]
        public async Task SearchAnime_HigurashiName_ShouldParseWhenTheyCry()
        {
            // When
            PaginatedList<SearchResult>? result;
            result = await _anime.SearchAnime("When they cry: kai");
            // Then
            Assert.Equal("Higurashi No Naku Koro Ni Kai", result.Results.First().Title);
        }

        [Fact]
        public async Task SearchAnime_ShouldBeEmpty()
        {
            // When
            PaginatedList<SearchResult>? result;
            // Then
            result = await _anime.SearchAnime("dmadpdama[pdmp[madpmapdmpad");
            Assert.True(result.Results.Count == 0);

        }


    }
}