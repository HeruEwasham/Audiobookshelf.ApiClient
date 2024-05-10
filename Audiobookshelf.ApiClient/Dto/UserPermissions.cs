using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class UserPermissions
    {
        /// <summary>
        /// Whether the user can download items to the server.
        /// </summary>
        [JsonProperty("download")]
        public bool Download { get; private set; }

        /// <summary>
        /// Whether the user can update library items.
        /// </summary>
        [JsonProperty("update")]
        public bool Update { get; private set; }

        /// <summary>
        /// Whether the user can delete library items.
        /// </summary>
        [JsonProperty("delete")]
        public bool Delete { get; private set; }

        /// <summary>
        /// Whether the user can upload items to the server.
        /// </summary>
        [JsonProperty("upload")]
        public bool Upload { get; private set; }

        /// <summary>
        /// Whether the user can access all libraries.
        /// </summary>
        [JsonProperty("accessAllLibraries")]
        public bool AccessAllLibraries { get; private set; }

        /// <summary>
        /// Whether the user can access all tags.
        /// </summary>
        [JsonProperty("accessAllTags")]
        public bool AccessAllTags { get; private set; }

        /// <summary>
        /// Whether the user can access explicit content.
        /// </summary>
        [JsonProperty("AccessExplicitContent")]
        public bool AccessExplicitContent { get; private set; }
    }
}