using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class Playlist<TItem> : LibraryUserCreatedBaseData where TItem : PlaylistItem
    {
        /// <summary>
        /// The path of the playlist's cover.
        /// </summary>
        [JsonProperty("coverPath")]
        public string CoverPath { get; private set; }

        /// <summary>
        /// The items in the playlist.
        /// </summary>
        [JsonProperty("items")]
        public TItem[] Items { get; private set; }
    }
}