using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastMetadata
    {
        /// <summary>
        /// The title of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The author of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// The description for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The release date of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// The podcast's genres.
        /// </summary>
        [JsonProperty("genres")]
        public string[] Genres { get; set; }

        /// <summary>
        /// A URL of an RSS feed for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("feedUrl")]
        public string FeedUrl { get; set; }

        /// <summary>
        /// A URL of a cover image for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// A URL of an iTunes page for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("itunesPageUrl")]
        public string ItunesPageUrl { get; set; }

        /// <summary>
        /// The iTunes ID for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("itunesId")]
        public int? ItunesId { get; set; }

        /// <summary>
        /// The iTunes Artist ID for the author of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("itunesArtistId")]
        public int? ItunesArtistId { get; set; }

        /// <summary>
        /// Whether the podcast has been marked as explicit.
        /// </summary>
        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

        /// <summary>
        /// The language of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// The type of the podcast.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}