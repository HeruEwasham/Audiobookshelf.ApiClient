using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastMetadata
    {
        /// <summary>
        /// The title of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// The author of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; private set; }

        /// <summary>
        /// The description for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The release date of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; private set; }

        /// <summary>
        /// The podcast's genres.
        /// </summary>
        [JsonProperty("genres")]
        public string[] Genres { get; private set; }

        /// <summary>
        /// A URL of an RSS feed for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("feedUrl")]
        public string FeedUrl { get; private set; }

        /// <summary>
        /// A URL of a cover image for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; private set; }

        /// <summary>
        /// A URL of an iTunes page for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("itunesPageUrl")]
        public string ItunesPageUrl { get; private set; }

        /// <summary>
        /// The iTunes ID for the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("itunesId")]
        public int? ItunesId { get; private set; }

        /// <summary>
        /// The iTunes Artist ID for the author of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("itunesArtistId")]
        public int? ItunesArtistId { get; private set; }

        /// <summary>
        /// Whether the podcast has been marked as explicit.
        /// </summary>
        [JsonProperty("explicit")]
        public bool Explicit { get; private set; }

        /// <summary>
        /// The language of the podcast. Will be null if unknown.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; private set; }

        /// <summary>
        /// The type of the podcast.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
    }
}