using System.Text.Json.Serialization;

namespace X00164441_CA3.Models
{
    public class PaginatedList<T> where T : class
    {
        [JsonPropertyName("currentPage")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonPropertyName("results")]
        public List<T> Results { get; set; } = new();
    }
}
