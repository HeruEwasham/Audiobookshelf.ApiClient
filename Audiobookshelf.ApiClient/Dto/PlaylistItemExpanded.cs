using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PlaylistItemExpanded<TLibraryItem> : PlaylistItem
    {
        /// <summary>
        /// The podcast episode the playlist item is for. Will only exist if episodeId is not null.
        /// </summary>
        [JsonProperty("episode")]
        public PodcastEpisodeExpanded Episode { get; private set; }

        /// <summary>
        /// The library item the playlist item is for. Will be Library Item Minified if episodeId is not null.
        /// </summary>
        [JsonProperty("libraryItem")]
        public TLibraryItem LibraryItem { get; private set; }
    }
}