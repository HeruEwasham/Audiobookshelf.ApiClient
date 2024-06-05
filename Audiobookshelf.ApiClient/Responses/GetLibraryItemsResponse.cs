using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
    public class GetLibraryItemsResponse<TLibraryItemType> : LibraryResultsResponse<TLibraryItemType>
    {
        /// <summary>
        /// The sort set in the request. Will not exist if no sort was set.
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; private set; }

        /// <summary>
        /// Whether to reverse the sort order.
        /// </summary>
        [JsonProperty("sortDesc")]
        public bool SortDesc { get; private set; }

        /// <summary>
        /// The filter set in the request, URL decoded. Will not exist if no filter was set.
        /// </summary>
        [JsonProperty("filterBy")]
        public string FilterBy { get; private set; }

        /// <summary>
        /// The media type of the library. Will be book or podcast.
        /// </summary>
        [JsonProperty("mediaType")]
        public MediaType MediaType { get; private set; }

        /// <summary>
        /// Whether minified was set in the request.
        /// </summary>
        [JsonProperty("minified")]
        public bool Minified { get; private set; }

        /// <summary>
        /// Whether collapseseries was set in the request.
        /// </summary>
        [JsonProperty("collapseseries")]
        public bool CollapseSeries { get; private set; }

        /// <summary>
        /// The requested include.
        /// </summary>
        [JsonProperty("include")]
        public string Include { get; private set; }
    }
}