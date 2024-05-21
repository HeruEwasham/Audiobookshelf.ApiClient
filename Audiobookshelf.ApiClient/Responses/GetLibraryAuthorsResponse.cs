using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class GetLibraryAuthorsResponse
	{
        /// <summary>
        /// The requested authors.
        /// </summary>
        [JsonProperty("authors")]
        public AuthorExpanded[] Authors { get; private set; }
    }
}

