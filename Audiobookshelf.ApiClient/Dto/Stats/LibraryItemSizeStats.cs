using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto.Stats
{
    public class LibraryItemSizeStats
	{
        /// <summary>
        /// The ID of the library item.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The title of the library item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// The size (in bytes) of the library item.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }
    }
}

