using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PlaylistItem
    {
        /// <summary>
        /// The ID of the library item the playlist item is for.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The ID of the podcast episode the playlist item is for.
        /// </summary>
        [JsonProperty("episodeId")]
        public string EpisodeId { get; private set; }
    }
}