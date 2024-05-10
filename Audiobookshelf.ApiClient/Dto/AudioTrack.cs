using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class AudioTrack
    {
        /// <summary>
        /// The index of the audio track.
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; private set; }

        /// <summary>
        /// When in the audio file the track starts.
        /// </summary>
        [JsonProperty("startOffset")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan StartOffset { get; private set; }

        /// <summary>
        /// The length of the audio track.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// The filename of the audio file the audio track belongs to.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// The URL path of the audio file.
        /// </summary>
        [JsonProperty("contentUrl")]
        public string ContentUrl { get; private set; }

        /// <summary>
        /// The MIME type of the audio file.
        /// </summary>
        [JsonProperty("mimeType")]
        public string MimeType { get; private set; }

        /// <summary>
        /// The metadata of the audio file.
        /// </summary>
        [JsonProperty("metadata")]
        public FileMetadata Metadata { get; private set; }
    }
}