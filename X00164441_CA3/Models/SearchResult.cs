using System.Text.Json.Serialization;

namespace X00164441_CA3.Models
{
    public class SearchResult
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        [JsonPropertyName("title")]
        public string Title { get; set; } = null!;

        [JsonPropertyName("image")]
        public string Image { get; set; } = null!;

        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; } = null!;

        [JsonPropertyName("subOrDub")]
        public string SubOrDub { get; set; } = null!;
    }
}
