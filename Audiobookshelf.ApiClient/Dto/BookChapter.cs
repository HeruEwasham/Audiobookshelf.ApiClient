using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class BookChapter
    {
        /// <summary>
        /// The ID of the book chapter.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; private set; }

        /// <summary>
        /// When in the book the chapter starts.
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Start { get; private set; }

        /// <summary>
        /// When in the book the chapter ends.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan End { get; private set; }

        /// <summary>
        /// The title of the chapter.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }
    }
}