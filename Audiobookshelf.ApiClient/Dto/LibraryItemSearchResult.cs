using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class LibraryItemSearchResult<TMedia>
    {
        /// <summary>
        /// The matched library item.
        /// </summary>
        [JsonProperty("libraryItem")]
        public LibraryItemExpanded<TMedia> LibraryItem { get; private set; }

        /// <summary>
        /// What the library item was matched on.
        /// </summary>
        [JsonProperty("matchKey")]
        public string MatchKey { get; private set; }

        /// <summary>
        /// The text in the library item that the query matched to.
        /// </summary>
        [JsonProperty("matchText")]
        public string MatchText { get; private set; }
    }
}