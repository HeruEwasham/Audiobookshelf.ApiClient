using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class GetLibraryRecentEpisodesResponse
	{
        /// <summary>
        /// The library's newest unfinished podcast episodes, sorted by episode publish time.
        /// </summary>
        [JsonProperty("episodes")]
        public PodcastEpisodeExpanded[] Episides { get; private set; }

        /// <summary>
        /// The total number of podcast episodes in the library.
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

