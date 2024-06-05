using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class RssFeed : RssFeedBase<RssFeedMetadata>
	{
        /// <summary>
        /// The slug (the last part of the URL) for the RSS feed.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; private set; }

        /// <summary>
        /// The ID of the user that created the RSS feed.
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; private set; }

        /// <summary>
        /// The path of the cover to use for the RSS feed.
        /// </summary>
        [JsonProperty("coverPath")]
        public string CoverPath { get; private set; }

        /// <summary>
        /// The server's address.
        /// </summary>
        [JsonProperty("serverAddress")]
        public string ServerAddress { get; private set; }

        /// <summary>
        /// The RSS feed's episodes.
        /// </summary>
        [JsonProperty("episodes")]
        public RssFeedEpisode[] Episodes { get; private set; }

        /// <summary>
        /// The time when the RSS feed was created.
        /// </summary>
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// The time when the RSS feed was last updated.
        /// </summary>
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }
    }
}

