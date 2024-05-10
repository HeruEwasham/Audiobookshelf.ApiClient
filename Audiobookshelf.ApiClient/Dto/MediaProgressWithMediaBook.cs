using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class MediaProgressWithMediaBook : MediaProgress
	{
        /// <summary>
        /// The media of the library item the media progress is for.
        /// </summary>
        [JsonProperty("media")]
		public BookExpanded Media { get; private set; }
	}
}

