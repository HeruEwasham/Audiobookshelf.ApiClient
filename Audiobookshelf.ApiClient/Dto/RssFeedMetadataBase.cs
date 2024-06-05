using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class RssFeedMetadataBase
    {
        /// <summary>
        /// The title of the entity the RSS feed is for.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// The description of the entity the RSS feed is for.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; } = null;

        /// <summary>
        /// Whether the RSS feed is marked to prevent indexing of the feed.
        /// </summary>
        [JsonProperty("preventIndexing")]
        public bool PreventIndexing { get; private set; }

        /// <summary>
        /// The owner name of the RSS feed.
        /// </summary>
        [JsonProperty("ownerName")]
        public string OwnerName { get; private set; } = null;

        /// <summary>
        /// The owner email of the RSS feed.
        /// </summary>
        [JsonProperty("ownerEmail")]
        public string OwnerEmail { get; private set; } = null;
    }
}