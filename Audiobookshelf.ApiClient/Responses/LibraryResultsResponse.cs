using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
    public class LibraryResultsResponse<TResult>
	{
        /// <summary>
        /// The results.
        /// </summary>
        [JsonProperty("results")]
        public TResult[] Results { get; private set; }

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
    }
}

