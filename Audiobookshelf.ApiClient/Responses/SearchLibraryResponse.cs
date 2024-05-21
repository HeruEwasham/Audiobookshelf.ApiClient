using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
    public class SearchLibraryResponse
	{
        /// <summary>
        /// The item results of the search. This attribute will only be populated if the librarys media type is book.
        /// </summary>
        [JsonProperty("book")]
        public LibraryItemSearchResult<Book>[] Book { get; private set; }

        /// <summary>
        /// The item results of the search. This attribute will only be populated if the librarys media type is podcast.
        /// </summary>
        [JsonProperty("podcast")]
        public LibraryItemSearchResult<Podcast>[] Podcast { get; private set; }

        /// <summary>
        /// The tag results of the search.
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; private set; }

        /// <summary>
        /// The author results of the search.
        /// </summary>
        [JsonProperty("authors")]
        public AuthorExpanded[] Authors { get; private set; }

        /// <summary>
        /// The library items that contain the books in the series. A sequence attribute that denotes the position in the series the book is in, is tacked on.
        /// </summary>
        [JsonProperty("series")]
        public SeriesBooks<BookLibraryItemSeries>[] Series { get; private set; }
    }
}

