using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public abstract class BookBase<TBookMetadata> where TBookMetadata : BookMetadataBase
	{
        /// <summary>
        /// The book's metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public TBookMetadata Metadata { get; private set; }

        /// <summary>
        /// The absolute path on the server of the cover file. Will be null if there is no cover.
        /// </summary>
        [JsonProperty("coverPath")]
        public string CoverPath { get; private set; }

        /// <summary>
        /// The book's tags.
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; private set; }
    }
}

