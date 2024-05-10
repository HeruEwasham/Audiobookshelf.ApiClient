using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class FileMetadata
    {
        /// <summary>
        /// The filename of the file.
        /// </summary>
        [JsonProperty("filename")]
        public string Filename { get; private set; }

        /// <summary>
        /// The file extension of the file.
        /// </summary>
        [JsonProperty("ext")]
        public string Extension { get; private set; }

        /// <summary>
        /// The absolute path on the server of the file.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; private set; }

        /// <summary>
        /// The path of the file, relative to the book's or podcast's folder.
        /// </summary>
        [JsonProperty("relPath")]
        public string RelPath { get; private set; }

        /// <summary>
        /// The size (in bytes) of the file.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }

        /// <summary>
        /// The time when the file was last modified on disk.
        /// </summary>
        [JsonProperty("mtimeMs")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime ModifiedTime { get; private set; }

        /// <summary>
        /// The time when the file status was changed on disk.
        /// </summary>
        [JsonProperty("ctimeMs")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime ChangedTime { get; private set; }

        /// <summary>
        /// The time when the file was created on disk. Will be POSIX epoch if unknown.
        /// </summary>
        [JsonProperty("birthtimeMs")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime BirthTime { get; private set; }
    }
}