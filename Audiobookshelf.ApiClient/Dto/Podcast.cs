using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class Podcast : Podcast<PodcastMetadata, PodcastEpisode> { }

    public class Podcast<TPodcastMetadata, TPodcastEpisode> : PodcastBase<TPodcastMetadata>
        where TPodcastMetadata : PodcastMetadata
        where  TPodcastEpisode : PodcastEpisode
    {
        /// <summary>
        /// The ID of the library item that contains the podcast.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The downloaded episodes of the podcast.
        /// </summary>
        [JsonProperty("episodes")]
        public TPodcastEpisode[] Episodes { get; private set; }
    }
}