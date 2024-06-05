using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class BookMetadata : BookMetadata<AuthorMinified, SeriesSequence> { }

    public class BookMetadata<TAuthorInfoType, TSeriesSequence> : BookMetadataBase where TAuthorInfoType : AuthorBase where TSeriesSequence : SeriesBase
    {
        /// <summary>
        /// The authors of the book.
        /// </summary>
        [JsonProperty("authors")]
        public TAuthorInfoType[] Authors { get; set; }

        /// <summary>
        /// The narrators of the audiobook.
        /// </summary>
        [JsonProperty("narrators")]
        public string[] Narrators { get; set; }

        /// <summary>
        /// The series the book belongs to.
        /// </summary>
        [JsonProperty("series")]
        public TSeriesSequence[] Series { get; set; }
    }
}