using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
    public class GetPodcastLibraryEpisodeDownloadResponse
	{
        /// <summary>
        /// The podcast episode currently being downloaded. Will only exist if an episode download is in progress.
        /// </summary>
        [JsonProperty("currentDownload")]
        public PodcastEpisodeDownload CurrentDownload { get; private set; }

        /// <summary>
        /// The podcast episodes in the queue to be downloaded.
        /// </summary>
        [JsonProperty("queue")]
        public PodcastEpisodeDownload[] Queue { get; private set; }
    }
}

