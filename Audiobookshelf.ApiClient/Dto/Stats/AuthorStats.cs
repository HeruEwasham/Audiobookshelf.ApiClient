using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto.Stats
{
    public class AuthorStats
	{
        /// <summary>
        /// The ID of the author.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the author.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// The number of books by the author in the library.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }
    }
}

