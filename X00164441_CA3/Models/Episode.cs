using System.Text.Json.Serialization;

namespace X00164441_CA3.Models
{
    public class Episode
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        [JsonPropertyName("number")]
        public int? Number { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; } = null!;
    }
}
