using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastMinified : PodcastBase<PodcastMetadataMinified>
	{
        /// <summary>
        /// The number of downloaded episodes for the podcast.
        /// </summary>
        [JsonProperty("numEpisodes")]
        public int NumberOfEpisodes { get; private set; }

        /// <summary>
        /// The total size (in bytes) of the podcast.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }
    }
}

