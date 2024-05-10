using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Requests
{
	public abstract class LibraryRequestBase
	{
        /// <summary>
        /// The name of the library.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The folders of the library. Only specify the fullPath.
        /// </summary>
        [JsonProperty("folders")]
        public Folder[] Folders { get; set; }

        /// <summary>
        /// The icon of the library.
        /// </summary>
        [JsonProperty("icon")]
        public LibraryIcon Icon { get; set; }

        /// <summary>
        /// Preferred metadata provider for the library. 
        /// </summary>
        [JsonProperty("provider")]
        public MetadataProvider Provider { get; set; }

        /// <summary>
        /// The settings for the library.
        /// </summary>
        [JsonProperty("settings")]
        public LibrarySettings Settings { get; set; }
    }
}

