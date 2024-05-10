using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class AudioFile
    {
        /// <summary>
        /// The index of the audio file.
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; private set; }

        /// <summary>
        /// The inode of the audio file.
        /// </summary>
        [JsonProperty("ino")]
        public string Inode { get; private set; }

        /// <summary>
        /// The audio file's metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public FileMetadata Metadata { get; private set; }

        /// <summary>
        /// The time when the audio file was added to the library.
        /// </summary>
        [JsonProperty("addedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// The time when the audio file last updated. 
        /// </summary>
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// The track number of the audio file as pulled from the file's metadata. Will be null if unknown.
        /// </summary>
        [JsonProperty("trackNumFromMeta")]
        public int? TrackNumberFromMetadata { get; private set; }

        /// <summary>
        /// The disc number of the audio file as pulled from the file's metadata. Will be null if unknown.
        /// </summary>
        [JsonProperty("discNumFromMeta")]
        public int? DiscNumberFromMetadata { get; private set; }

        /// <summary>
        /// The track number of the audio file as determined from the file's name. Will be null if unknown.
        /// </summary>
        [JsonProperty("trackNumFromFilename")]
        public int? TrackNumberFromFilename { get; private set; }

        /// <summary>
        /// The track number of the audio file as determined from the file's name. Will be null if unknown.
        /// </summary>
        [JsonProperty("discNumFromFilename")]
        public int? DiscNumberFromFilename { get; private set; }

        /// <summary>
        /// Whether the audio file has been manually verified by a user.
        /// </summary>
        [JsonProperty("manuallyVerified")]
        public bool ManuallyVerified { get; private set; }

        /// <summary>
        /// Whether the audio file is missing from the server.
        /// </summary>
        [JsonProperty("invalid")]
        public bool Invalid { get; private set; }

        /// <summary>
        /// Whether the audio file has been marked for exclusion.
        /// </summary>
        [JsonProperty("exclude")]
        public bool Exclude { get; private set; }

        /// <summary>
        /// Any error with the audio file. Will be null if there is none.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; private set; }

        /// <summary>
        /// The format of the audio file.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; private set; }

        /// <summary>
        /// The total length of the audio file.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// The bit rate (in bit/s) of the audio file.
        /// </summary>
        [JsonProperty("bitRate")]
        public int BitRate { get; private set; }

        /// <summary>
        /// The language of the audio file.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; private set; }

        /// <summary>
        /// The codec of the audio file.
        /// </summary>
        [JsonProperty("codec")]
        public string Codec { get; private set; }

        /// <summary>
        /// The time base of the audio file.
        /// </summary>
        [JsonProperty("timeBase")]
        public string TimeBase { get; private set; }

        /// <summary>
        /// The number of channels the audio file has.
        /// </summary>
        [JsonProperty("channels")]
        public int Channels { get; private set; }

        /// <summary>
        /// The layout of the audio file's channels.
        /// </summary>
        [JsonProperty("channelLayout")]
        public string ChannelLayout { get; private set; }

        /// <summary>
        /// If the audio file is part of an audiobook, the chapters the file contains.
        /// </summary>
        [JsonProperty("chapters")]
        public BookChapter[] Chapters { get; private set; }

        /// <summary>
        /// The type of embedded cover art in the audio file. Will be null if none exists.
        /// </summary>
        [JsonProperty("embeddedCoverArt")]
        public string EmbeddedCoverArt { get; private set; }

        /// <summary>
        /// The audio metadata tags from the audio file.
        /// </summary>
        [JsonProperty("metaTags")]
        public AudioMetaTags[] MetaTags { get; private set; }

        /// <summary>
        /// The MIME type of the audio file.
        /// </summary>
        [JsonProperty("mimeType")]
        public string MimeType { get; private set; }
    }
}