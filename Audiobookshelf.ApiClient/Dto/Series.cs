using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class Series : SeriesBaseWithAddedAt
	{
        /// <summary>
        /// A description for the series. Will be null if there is none.
        /// </summary>
        [JsonProperty("description")]
		public string Description { get; private set; }

        /// <summary>
        /// The time when the series was last updated.
        /// </summary>
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }
    }
}

