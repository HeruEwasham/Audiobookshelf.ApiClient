using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Requests
{
    public class ReorderLibraryListRequest
	{
        /// <summary>
        /// The ID of the library to set the displayOrder of.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The new displayOrder for the library.
        /// </summary>
        [JsonProperty("newOrder")]
        public int NewOrder { get; set; }
    }
}

