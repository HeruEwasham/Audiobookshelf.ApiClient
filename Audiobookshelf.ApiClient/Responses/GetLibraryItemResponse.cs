using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
    public class GetLibraryItemResponse<TLibraryItemType>
    {
        /// <summary>
        /// The requested library items. If minified is true, it will be an array of Library Item Minified. collapseseries will add a Series Num Books as collapsedSeries to the library items, with only one library item per series. However, if there is only one series in the results, they will not be collapsed. When filtering by series, media.metadata.series will be replaced by the matching Series Sequence object. If filtering by series, collapseseries is true, and there are multiple series, such as a subseries, a seriesSequenceList string attribute is added to collapsedSeries which represents the items in the subseries that are in the filtered series. rssfeed will add an RSS Feed Minified object or null as rssFeed to the library items, the item's RSS feed if it has one open.
        /// </summary>
        [JsonProperty("results")]
        public TLibraryItemType[] Results { get; private set; }

        /// <summary>
        /// The total number of results.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; private set; }

        /// <summary>
        /// The limit set in the request.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; private set; }

        /// <summary>
        /// The page set in request.
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; private set; }

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