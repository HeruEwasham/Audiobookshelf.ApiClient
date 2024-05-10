using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class SeriesNumBooks : SeriesBase
	{
        /// <summary>
        /// The name of the series with any prefix moved to the end.
        /// </summary>
        [JsonProperty("nameIgnorePrefix")]
		public string NameIgnorePrefix { get; private set; }

        /// <summary>
        /// The IDs of the library items in the series.
        /// </summary>
        [JsonProperty("libraryItemIds")]
        public string[] LibraryItemIds { get; private set; }

        /// <summary>
        /// The number of books in the series.
        /// </summary>
        [JsonProperty("numBooks")]
        public int NumBooks { get; private set; }
    }
}

