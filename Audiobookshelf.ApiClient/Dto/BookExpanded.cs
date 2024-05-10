using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class BookExpanded : Book<BookMetadataExpanded>
    {
        /// <summary>
        /// The total length of the book.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// The total size (in bytes) of the book.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }

        /// <summary>
        /// The book's audio tracks from the audio files.
        /// </summary>
        [JsonProperty("tracks")]
        public AudioTrack[] Tracks { get; private set; }
    }
}