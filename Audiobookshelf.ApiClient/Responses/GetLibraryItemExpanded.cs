using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
    public class GetLibraryItemExpanded<ExpandedMetadata> : LibraryItemExpanded<ExpandedMetadata>
	{
        /// <summary>
        /// If progress was requested, the user's progress for the book or podcast episode. If no progress exists, this attribute will be null.
        /// </summary>
        [JsonProperty("userMediaProgress")]
        public MediaProgress UserMediaProgress { get; private set; } = null;

        /// <summary>
        /// If rssfeed was requested, the open RSS feed of the library item. Will be null if the RSS feed for this library item is closed.
        /// </summary>
        [JsonProperty("rssFeed")]
        public RssFeedMinified RssFeed { get; private set; } = null;
    }
}