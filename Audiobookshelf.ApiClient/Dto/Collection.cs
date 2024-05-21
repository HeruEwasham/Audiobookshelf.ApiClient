using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class Collection<TLibraryItem> : LibraryUserCreatedBaseData
    {
        /// <summary>
        /// The books that belong to the collection.
        /// </summary>
        [JsonProperty("books")]
        public TLibraryItem[] Books { get; private set; }
    }
}

