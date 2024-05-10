using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class AudioBookmarks
    {
        /// <summary>
        /// The ID of the library item the bookmark is for.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The title of the bookmark.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// The time the bookmark is at in the book.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Time { get; private set; }

        /// <summary>
        /// The time when the bookmark was created.
        /// </summary>
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime CreatedAt { get; private set; }
    }
}