using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class MediaProgressWithMediaPodcast : MediaProgress
	{
        /// <summary>
        /// The media of the library item the media progress is for.
        /// </summary>
        [JsonProperty("media")]
        public PodcastExpanded Media { get; private set; }

        /// <summary>
        /// The podcast episode the media progress is for. Will only exist if the media progress is for a podcast episode.
        /// </summary>
        [JsonProperty("episode")]
        public PodcastEpisode Episode { get; private set; }
    }
}

