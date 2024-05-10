using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class Folder
	{
        /// <summary>
        /// The ID of the folder.
        /// </summary>
        [JsonProperty("id")]
		public string Id { get; private set; }

        /// <summary>
        /// The path on the server for the folder.
        /// </summary>
        [JsonProperty("fullPath")]
        public string FullPath { get; private set; }

        /// <summary>
        /// The ID of the library the folder belongs to.
        /// </summary>
        [JsonProperty("libraryId")]
        public string LibraryId { get; private set; }

        /// <summary>
        /// The time when the folder was added.
        /// </summary>
        [JsonProperty("addedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// Creates a new Folder-objeect. You are only able to define the full path to the folder. Other values are added by the server.
        /// </summary>
        /// <param name="fullPath">The path on the server for the folder.</param>
        public Folder(string fullPath)
		{
            FullPath = fullPath;
		}
	}
}

