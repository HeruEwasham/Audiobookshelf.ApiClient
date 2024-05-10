using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class Author : AuthorBase
	{
        /// <summary>
        /// The ASIN of the author. Will be null if unknown.
        /// </summary>
        [JsonProperty("asin")]
		public string Asin { get; private set; }

        /// <summary>
        /// A description of the author. Will be null if there is none.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The absolute path for the author image. Will be null if there is no image.
        /// </summary>
        [JsonProperty("imagePath")]
        public string ImagePath { get; private set; }

        /// <summary>
        /// The time when the author was added.
        /// </summary>
        [JsonProperty("addedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// The time when the author was last updated.
        /// </summary>
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }
    }
}

