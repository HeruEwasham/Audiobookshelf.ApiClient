using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Requests
{
	public class UpdateLibraryRequest : LibraryRequestBase
	{
        /// <summary>
        /// Display position of the library in the list of libraries. Must be >= 1.
        /// </summary>
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }
}

