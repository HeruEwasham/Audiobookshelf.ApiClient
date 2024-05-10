using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class BookMinified : BookBase<BookMetadataMinified>
    {
        /// <summary>
        /// The number of tracks the book's audio files have.
        /// </summary>
        [JsonProperty("numTracks")]
        public int NumberOfTracks { get; private set; }

        /// <summary>
        /// The number of audio files the book has.
        /// </summary>
        [JsonProperty("numAudioFiles")]
        public int NumberOfAudioFiles { get; private set; }

        /// <summary>
        /// The number of chapters the book has.
        /// </summary>
        [JsonProperty("numChapters")]
        public int NumberOfChapters { get; private set; }

        /// <summary>
        /// The total number of missing parts the book has.
        /// </summary>
        [JsonProperty("numMissingParts")]
        public int NumberOfMissingParts { get; private set; }

        /// <summary>
        /// The number of invalid audio files the book has.
        /// </summary>
        [JsonProperty("numInvalidAudioFiles")]
        public int NumberOfInvalidAudioFiles { get; private set; }

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
        /// The format of ebook of the book. Will be null if the book is an audiobook.
        /// </summary>
        [JsonProperty("ebookFormat")]
        public string EbookFormat { get; private set; }
    }
}