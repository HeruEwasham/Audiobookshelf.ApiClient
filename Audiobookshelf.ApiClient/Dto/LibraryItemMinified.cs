using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class LibraryItemMinified<TMedia> : LibraryItemBase<TMedia>
	{
        /// <summary>
        /// The number of library files for the library item.
        /// </summary>
        [JsonProperty("numFiles")]
        public int NumberOfFiles { get; private set; }

        /// <summary>
        /// The total size (in bytes) of the library item.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }
    }
}

