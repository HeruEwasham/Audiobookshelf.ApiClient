using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class EbookFile
    {
        /// <summary>
        /// The inode of the ebook file.
        /// </summary>
        [JsonProperty("ino")]
        public string Inode { get; private set; }

        /// <summary>
        /// The metadata of the ebook file.
        /// </summary>
        [JsonProperty("metadata")]
        public FileMetadata Metadata { get; private set; }

        /// <summary>
        /// The ebook format of the ebook file.
        /// </summary>
        [JsonProperty("ebookFormat")]
        public string EbookFormat { get; private set; }

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
    }
}