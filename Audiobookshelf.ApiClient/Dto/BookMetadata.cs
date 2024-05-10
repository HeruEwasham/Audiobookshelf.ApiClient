using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class BookMetadata : BookMetadataBase
    {
        /// <summary>
        /// The authors of the book.
        /// </summary>
        [JsonProperty("authors")]
        public AuthorMinified[] Authors { get; private set; }

        /// <summary>
        /// The narrators of the audiobook.
        /// </summary>
        [JsonProperty("narrators")]
        public string[] Narrators { get; private set; }

        /// <summary>
        /// The series the book belongs to.
        /// </summary>
        [JsonProperty("series")]
        public SeriesSequence[] Series { get; private set; }
    }
}