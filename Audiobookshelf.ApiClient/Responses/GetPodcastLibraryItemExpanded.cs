using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class GetPodcastLibraryItemExpanded : GetLibraryItemExpanded<PodcastLibraryItemExpanded>
	{
        /// <summary>
        /// If downloads was requested, the podcast episodes currently in the download queue.
        /// </summary>
        [JsonProperty("episodesDownloading")]
        public PodcastEpisodeDownload[] EpisodesDownloading { get; private set; }
    }
}

