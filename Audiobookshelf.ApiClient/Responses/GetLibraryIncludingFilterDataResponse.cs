using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class GetLibraryIncludingFilterDataResponse
	{
        /// <summary>
        /// The library's filter data that can be used for displaying a filter list.
        /// </summary>
        [JsonProperty("filterdata")]
		public LibraryFilterData FilterData { get; private set; }

        /// <summary>
        /// The number of library items in the library that have issues.
        /// </summary>
        [JsonProperty("issues")]
        public int Issues { get; private set; }

        /// <summary>
        /// The number of playlists belonging to this library for the authenticated user.
        /// </summary>
        [JsonProperty("numUserPlaylists")]
        public int NumberOfUserPlaylists { get; private set; }

        /// <summary>
        /// The requested library.
        /// </summary>
        [JsonProperty("library")]
        public Library Library { get; private set; }
    }
}

