using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class PodcastEpisodeExpandedWithPodcastMinified : PodcastEpisodeExpanded
	{
        /// <summary>
        /// The podcast the episode belongs to.
        /// </summary>
        [JsonProperty("podcast")]
        public PodcastMinified Podcast { get; private set; }
    }
}

