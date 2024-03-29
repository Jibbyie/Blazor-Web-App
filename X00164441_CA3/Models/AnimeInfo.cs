﻿using System.Text.Json.Serialization;

namespace X00164441_CA3.Models
{
    public class AnimeDetails : Anime
    {
        [JsonPropertyName("totalEpisodes")]
        public int? TotalEpisodes { get; set; } = null!;

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