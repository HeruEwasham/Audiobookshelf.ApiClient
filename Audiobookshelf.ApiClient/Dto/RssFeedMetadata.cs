using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class RssFeedMetadata : RssFeedMetadataBase
	{
        /// <summary>
        /// The author of the entity the RSS feed is for.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; private set; } = null;

        /// <summary>
        /// The URL of the RSS feed's image.
        /// </summary>
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; private set; }

        /// <summary>
        /// The URL of the RSS feed.
        /// </summary>
        [JsonProperty("feedUrl")]
        public string FeedUrl { get; private set; }

        /// <summary>
        /// The URL of the entity the RSS feed is for.
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; private set; }

        /// <summary>
        /// Whether the RSS feed's contents are explicit.
        /// </summary>
        [JsonProperty("explicit")]
        public bool Explicit { get; private set; }

        /// <summary>
        /// The type of the RSS feed.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; } = null;

        /// <summary>
        /// The language of the RSS feed.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; private set; } = null;
    }
}

