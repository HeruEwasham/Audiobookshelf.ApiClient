using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastEpisodeEnclosure
    {
        /// <summary>
        /// The URL where the podcast episode's audio file was downloaded from.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; private set; }

        /// <summary>
        /// The MIME type of the podcast episode's audio file.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The size (in bytes) that was reported when downloading the podcast episode's audio file.
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; private set; }
    }
}