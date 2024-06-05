using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public abstract class SeriesBaseWithAddedAt : SeriesBaseWithId
	{
        /// <summary>
        /// The time when the series was added.
        /// </summary>
        [JsonProperty("addedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime AddedAt { get; private set; }
    }
}

