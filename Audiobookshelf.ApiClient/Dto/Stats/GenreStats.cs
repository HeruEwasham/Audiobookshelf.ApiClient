using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto.Stats
{
    public class GenreStats
	{
        /// <summary>
        /// The name of the genre.
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; private set; }

        /// <summary>
        /// The number of items in the library with the genre.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }
    }
}

