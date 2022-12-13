using System.Text.Json.Serialization;

namespace X00164441_CA3.Models
{
    public class AnimeInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        [JsonPropertyName("title")]
        public string Title { get; set; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; set; } = null!;

        [JsonPropertyName("genres")]
        public List<string> Genres { get; set; } = null!;

        [JsonPropertyName("totalEpisodes")]
        public int? TotalEpisodes { get; set; } = null!;

        [JsonPropertyName("image")]
        public string Image { get; set; } = null!;

        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; } = null!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = null!;

        [JsonPropertyName("subOrDub")]
        public string SubOrDub { get; set; } = null!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = null!;

        [JsonPropertyName("otherName")]
        public string OtherName { get; set; } = null!;

        [JsonPropertyName("episodes")]
        public List<Episode> Episodes { get; set; } = null!;
    }
}
