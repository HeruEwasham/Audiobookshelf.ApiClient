using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class LibraryFilterData
	{
        /// <summary>
        /// The authors of books in the library.
        /// </summary>
        [JsonProperty("authors")]
		public AuthorMinified[] Authors { get; private set; }

        /// <summary>
        /// The genres of books in the library.
        /// </summary>
        [JsonProperty("genres")]
        public string[] Genres { get; private set; }

        /// <summary>
        /// The tags in the library.
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; private set; }

        /// <summary>
        /// The series in the library.
        /// </summary>
        [JsonProperty("series")]
        public SeriesMinified[] Series { get; private set; }

        /// <summary>
        /// The narrators of books in the library.
        /// </summary>
        [JsonProperty("narrators")]
        public string[] Narrators { get; private set; }

        /// <summary>
        /// The languages of books in the library.
        /// </summary>
        [JsonProperty("languages")]
        public string[] Languages { get; private set; }

        /// <summary>
        /// The publishers of books in the library.
        /// </summary>
        [JsonProperty("publishers")]
        public string[] Publishers { get; private set; }

        /// <summary>
        /// The number of library items in the library that have issues.
        /// </summary>
        [JsonProperty("numIssues")]
        public int NumberOfIssues { get; private set; }

        /// <summary>
        /// The time when the the data was loaded.
        /// </summary>
        [JsonProperty("loadedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime LoadedAt { get; private set; }
    }
}

