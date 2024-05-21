using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class SeriesWithShelfExtra : Series
    {
        /// <summary>
        /// The books in the series. Each library item in books will have a seriesSequence attribute, a String or null, the position of the book in the series.
        /// </summary>
        [JsonProperty("books")]
        public LibraryItemMinified<BookMinifiedWithSeriesSequence>[] Books { get; private set; }

        /// <summary>
        /// Whether the user has started listening to the series.
        /// </summary>
        [JsonProperty("inProgress")]
        public bool InProgress { get; private set; }

        /// <summary>
        /// Whether the user has started listening to the series, but has not finished it.
        /// </summary>
        [JsonProperty("hasActiveBook")]
        public bool HasActiveBook { get; private set; }

        /// <summary>
        /// Whether the series has been marked to hide it from the "Continue Series" shelf.
        /// </summary>
        [JsonProperty("hideFromContinueListening")]
        public bool HideFromContinueListening { get; private set; }

        /// <summary>
        /// The latest time when the progress of a book in the series was updated.
        /// </summary>
        [JsonProperty("bookInProgressLastUpdate")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime BookInProgressLastUpdate { get; private set; }

        /// <summary>
        /// The first book in the series (by sequence) to have not been started or finished. Will be null if the user has started or finished all books in the series. This library item will also have a seriesSequence attribute.
        /// </summary>
        [JsonProperty("firstBookUnread")]
        public LibraryItemMinified<BookMinifiedWithSeriesSequence> FirstBookUnread { get; private set; }
    }
}