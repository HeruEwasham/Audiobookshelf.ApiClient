using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class UpdateLibraryItemMediaResponse<TMedia> : LibraryItem<TMedia>
	{
        /// <summary>
        /// Whether anything was actually changed.
        /// </summary>
        [JsonProperty("updated")]
        public bool Updated { get; private set; }
    }
}

