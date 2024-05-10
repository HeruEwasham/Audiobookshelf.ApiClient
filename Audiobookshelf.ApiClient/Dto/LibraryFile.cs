using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class LibraryFile
    {
        /// <summary>
        /// The inode of the library file.
        /// </summary>
        [JsonProperty("ino")]
        public string Inode { get; private set; }

        /// <summary>
        /// The metadata for the library file.
        /// </summary>
        [JsonProperty("metadata")]
        public FileMetadata Metadata { get; private set; }

        /// <summary>
        /// The time when the library file was added.
        /// </summary>
        [JsonProperty("addedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// The time when the library file was last updated.
        /// </summary>
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// The type of file that the library file is (audio, image, etc.).
        /// </summary>
        [JsonProperty("fileType")]
        public string FileType { get; private set; }
    }
}