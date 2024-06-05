using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class RssFeedBase<TRssFeedMetadata>
	{
        /// <summary>
        /// The ID of the RSS feed.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The type of entity the RSS feed is for.
        /// </summary>
        [JsonProperty("entityType")]
        public string EntityType { get; private set; }

        /// <summary>
        /// The ID of the entity the RSS feed is for.
        /// </summary>
        [JsonProperty("entityId")]
        public string EntityId { get; private set; }

        /// <summary>
        /// The full URL of the RSS feed.
        /// </summary>
        [JsonProperty("feedUrl")]
        public string FeedUrl { get; private set; }

        /// <summary>
        /// The RSS feed's metadata.
        /// </summary>
        [JsonProperty("meta")]
        public TRssFeedMetadata Metadata { get; private set; }
    }
}

