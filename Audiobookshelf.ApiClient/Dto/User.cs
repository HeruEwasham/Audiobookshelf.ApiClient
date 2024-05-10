using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class User
    {
        /// <summary>
        /// The ID of the user. Only the root user has the root ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; }

        /// <summary>
        /// The username of the user.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; private set; }

        /// <summary>
        /// The type of the user. Will be root, guest, user, or admin. There will be only one root user which is created when the server first starts.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The authentication token of the user.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; private set; }

        /// <summary>
        /// The user's media progress.
        /// </summary>
        [JsonProperty("mediaProgress")]
        public MediaProgress[] MediaProgress { get; private set; }

        /// <summary>
        /// The IDs of series to hide from the user's "Continue Series" shelf.
        /// </summary>
        [JsonProperty("seriesHideFromContinueListening")]
        public string[] SeriesHideFromContinueListening { get; private set; }

        /// <summary>
        /// The user's bookmarks.
        /// </summary>
        [JsonProperty("bookmarks")]
        public AudioBookmarks[] Bookmarks { get; private set; }

        /// <summary>
        /// Whether the user's account is active.
        /// </summary>
        [JsonProperty("isActive")]
        public bool IsActive { get; private set; }

        /// <summary>
        /// Whether the user is locked.
        /// </summary>
        [JsonProperty("isLocked")]
        public bool IsLocked { get; private set; }

        /// <summary>
        /// The time when the user was last seen by the server. Will be null if the user has never logged in.
        /// </summary>
        [JsonProperty("lastSeen")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime? LastSeen { get; private set; }

        /// <summary>
        /// The time when the user was created.
        /// </summary>
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// The user's permissions.
        /// </summary>
        [JsonProperty("permissions")]
        public UserPermissions Permissions { get; private set; }

        /// <summary>
        /// The IDs of libraries accessible to the user. An empty array means all libraries are accessible.
        /// </summary>
        [JsonProperty("librariesAccessible")]
        public string[] LibrariesAccessible { get; private set; }

        /// <summary>
        /// The tags accessible to the user. An empty array means all tags are accessible.
        /// </summary>
        [JsonProperty("itemTagsAccessible")]
        public string[] ItemTagsAccessible { get; private set; }
    }
}