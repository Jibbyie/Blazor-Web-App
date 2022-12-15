using System.Text.Json.Serialization;

namespace X00164441_CA3.Models
{
    public class Anime
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        [JsonPropertyName("title")]
        public string Title { get; set; } = null!;

        [JsonPropertyName("image")]
        public string Image { get; set; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; set; } = null!;

        [JsonPropertyName("genres")]
        public List<string> Genres { get; set; } = null!;
    }
}
