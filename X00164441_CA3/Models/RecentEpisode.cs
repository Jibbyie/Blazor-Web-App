using System.Text.Json.Serialization;

namespace X00164441_CA3.Models
{
    public class RecentEpisode
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        [JsonPropertyName("episodeId")]
        public string EpisodeId { get; set; } = null!;

        [JsonPropertyName("episodeNumber")]
        public int EpisodeNumber { get; set; } 

        [JsonPropertyName("title")]
        public string Title { get; set; } = null!;

        [JsonPropertyName("image")]
        public string Image { get; set; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; set; } = null!;
    }
}
