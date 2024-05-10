using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class LibraryItemBase<TMedia>
    {
        /// <summary>
        /// The ID of the library item.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The inode of the library item.
        /// </summary>
        [JsonProperty("ino")]
        public string Inode { get; private set; }

        /// <summary>
        /// The ID of the library the item belongs to.
        /// </summary>
        [JsonProperty("libraryId")]
        public string LibraryId { get; private set; }

        /// <summary>
        /// The ID of the folder the library item is in.
        /// </summary>
        [JsonProperty("folderId")]
        public string FolderId { get; private set; }

        /// <summary>
        /// The path of the library item on the server.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; private set; }

        /// <summary>
        /// The path, relative to the library folder, of the library item.
        /// </summary>
        [JsonProperty("relPath")]
        public string RelPath { get; private set; }

        /// <summary>
        /// Whether the library item is a single file in the root of the library folder.
        /// </summary>
        [JsonProperty("isFile")]
        public bool IsFile { get; private set; }

        /// <summary>
        /// The time when the library item was last modified on disk.
        /// </summary>
        [JsonProperty("mtimeMs")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime ModifiedTime { get; private set; }

        /// <summary>
        /// The time when the library item status was changed on disk.
        /// </summary>
        [JsonProperty("ctimeMs")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime ChangedTime { get; private set; }

        /// <summary>
        /// The time when the library item was created on disk. Will be POSIX epoch if unknown.
        /// </summary>
        [JsonProperty("birthtimeMs")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime BirthTime { get; private set; }

        /// <summary>
        /// The time when the library item was added to the library.
        /// </summary>
        [JsonProperty("addedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// The time when the library item was last updated.
        /// </summary>
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Whether the library item was scanned and no longer exists.
        /// </summary>
        [JsonProperty("isMissing")]
        public bool IsMissing { get; private set; }

        /// <summary>
        /// Whether the library item was scanned and no longer has media files.
        /// </summary>
        [JsonProperty("isInvalid")]
        public bool IsInvalid { get; private set; }

        /// <summary>
        /// What kind of media the library item contains. Will be book or podcast.
        /// </summary>
        [JsonProperty("mediaType")]
        public MediaType MediaType { get; private set; }

        /// <summary>
        /// The media of the library item.
        /// </summary>
        [JsonProperty("media")]
        public TMedia Media { get; private set; }
    }
}