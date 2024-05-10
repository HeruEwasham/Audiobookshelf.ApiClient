using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;
using System;

namespace Audiobookshelf.ApiClient.Dto
{
    public class LibraryItem<TMedia> : LibraryItemBase<TMedia>
    {
        /// <summary>
        /// The time when the library item was last scanned. Will be null if the server has not yet scanned the library item.
        /// </summary>
        [JsonProperty("lastScan")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime? LastScan { get; private set; }

        /// <summary>
        /// The version of the scanner when last scanned. Will be null if it has not been scanned.
        /// </summary>
        [JsonProperty("scanVersion")]
        public string ScanVersion { get; private set; }

        /// <summary>
        /// The files of the library item.
        /// </summary>
        [JsonProperty("libraryFiles")]
        public LibraryFile[] LibraryFiles { get; private set; }
    }
}