using System;
using System.Drawing;
using Audiobookshelf.ApiClient.Dto;
using Audiobookshelf.ApiClient.Dto.Stats;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class GetLibraryStatsResponse
	{
        /// <summary>
        /// The total amount of library items in the library.
        /// </summary>
        [JsonProperty("totalItems")]
        public int TotalItems { get; private set; }

        /// <summary>
        /// The total amount of authors in the library.
        /// </summary>
        [JsonProperty("totalAuthors")]
        public int TotalAuthors { get; private set; }

        /// <summary>
        /// The total amount of genres in the library.
        /// </summary>
        [JsonProperty("totalGenres")]
        public int TotalGenres { get; private set; }

        /// <summary>
        /// The total duration of all items in the library.
        /// </summary>
        [JsonProperty("totalDuration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan TotalDuration { get; private set; }

        /// <summary>
        /// The items with the longest durations in the library.
        /// </summary>
        [JsonProperty("longestItems")]
        public LibraryItemDurationStats[] LongestItems { get; private set; }

        /// <summary>
        /// The total number of audio tracks in the library.
        /// </summary>
        [JsonProperty("numAudioTrack")]
        public int NumberOfAudioTracks { get; private set; }

        /// <summary>
        /// The total size (in bytes) of all items in the library.
        /// </summary>
        [JsonProperty("totalSize")]
        public int TotalSize { get; private set; }

        /// <summary>
        /// The items with the largest size in the library.
        /// </summary>
        [JsonProperty("largestItems")]
        public LibraryItemSizeStats[] LargestItems { get; private set; }

        /// <summary>
        /// The authors in the library.
        /// </summary>
        [JsonProperty("authorsWithCount")]
        public AuthorStats[] AuthorsWithCount { get; private set; }

        /// <summary>
        /// The genres in the library.
        /// </summary>
        [JsonProperty("genresWithCount")]
        public GenreStats[] GenresWithCount { get; private set; }
    }
}

