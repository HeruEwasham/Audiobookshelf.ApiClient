using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class Library
	{
        /// <summary>
        /// The ID of the library.
        /// </summary>
        [JsonProperty("id")]
		public string Id { get; private set; }

        /// <summary>
        /// The name of the library.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// The folders that the library is composed of on the server.
        /// </summary>
        [JsonProperty("folders")]
        public Folder[] Folders { get; private set; }

        /// <summary>
        /// Display position of the library in the list of libraries. Must be >= 1.
        /// </summary>
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; private set; }

        /// <summary>
        /// The selected icon for the library.
        /// </summary>
        [JsonProperty("icon")]
        public LibraryIcon Icon { get; private set; }

        /// <summary>
        /// The type of media that the library contains.
        /// </summary>
        [JsonProperty("mediaType")]
        public MediaType MediaType { get; private set; }

        /// <summary>
        /// Preferred metadata provider for the library.
        /// </summary>
        [JsonProperty("provider")]
        public MetadataProvider Provider { get; private set; }

        /// <summary>
        /// The settings for the library.
        /// </summary>
        [JsonProperty("settings")]
        public LibrarySettings Settings { get; private set; }

        /// <summary>
        /// The time when the library was created.
        /// </summary>
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// The time when the library was last updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime LastUpdate { get; private set; }
    }
}

