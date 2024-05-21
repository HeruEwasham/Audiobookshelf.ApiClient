using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class LibraryUserCreatedBaseData
    {
        /// <summary>
        /// The ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The ID of the library this object belongs to.
        /// </summary>
        [JsonProperty("libraryId")]
        public string LibraryId { get; private set; }

        /// <summary>
        /// The ID of the user that created the object.
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; private set; }

        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// The description. Will be null if there is none.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The time when the collection was last updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime LastUpdate { get; private set; }

        /// <summary>
        /// The time when the collection was created.
        /// </summary>
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime CreatedAt { get; private set; }
    }
}