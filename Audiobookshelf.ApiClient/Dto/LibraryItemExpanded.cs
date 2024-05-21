using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class LibraryItemExpanded<TMedia> : LibraryItem<TMedia>
	{
        /// <summary>
        /// The total size (in bytes) of the library item.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }
    }
}

