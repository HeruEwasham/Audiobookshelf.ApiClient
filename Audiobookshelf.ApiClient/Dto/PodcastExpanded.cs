using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastExpanded : Podcast<PodcastMetadataExpanded, PodcastEpisodeExpanded>
    {
        /// <summary>
        /// The total size (in bytes) of the podcast.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }
    }
}