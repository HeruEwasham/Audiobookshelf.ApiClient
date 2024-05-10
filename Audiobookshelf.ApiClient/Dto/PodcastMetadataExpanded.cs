using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastMetadataExpanded : PodcastMetadata
    {
        /// <summary>
        /// The title of the podcast with any prefix moved to the end.
        /// </summary>
        [JsonProperty("titleIgnorePrefix")]
        public string TitleIgnorePrefix { get; private set; }
    }
}