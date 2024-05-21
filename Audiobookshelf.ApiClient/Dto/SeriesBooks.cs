using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class SeriesBooks<TLibraryItem> : SeriesBaseWithAddedAt
	{
        /// <summary>
        /// The name of the series with any prefix moved to the end.
        /// </summary>
        [JsonProperty("nameIgnorePrefix")]
        public string NameIgnorePrefix { get; private set; }

        /// <summary>
        /// The name of the series with any prefix removed.
        /// </summary>
        [JsonProperty("nameIgnorePrefixSort")]
        public string NameIgnorePrefixSort { get; private set; }

        /// <summary>
        /// Will always be series.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The library items that contain the books in the series. A sequence attribute that denotes the position in the series the book is in, is tacked on.
        /// </summary>
        [JsonProperty("books")]
        public TLibraryItem[] Books { get; private set; }

        /// <summary>
        /// The combined duration of all books in the series.
        /// </summary>
        [JsonProperty("totalDuration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan TotalDuration { get; private set; }
    }
}

