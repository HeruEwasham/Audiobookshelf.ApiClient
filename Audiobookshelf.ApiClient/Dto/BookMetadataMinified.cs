using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class BookMetadataMinified : BookMetadataBase
    {
        /// <summary>
        /// The title of the book with any prefix moved to the end.
        /// </summary>
        [JsonProperty("titleIgnorePrefix")]
        public string TitleIgnorePrefix { get; private set; }

        /// <summary>
        /// The name of the book's author(s).
        /// </summary>
        [JsonProperty("authorName")]
        public string AuthorName { get; private set; }

        /// <summary>
        /// The name of the book's author(s) with last names first.
        /// </summary>
        [JsonProperty("authorNameLF")]
        public string AuthorNameLF { get; private set; }

        /// <summary>
        /// TThe name of the audiobook's narrator(s).
        /// </summary>
        [JsonProperty("narratorName")]
        public string NarratorName { get; private set; }

        /// <summary>
        /// The name of the book's series.
        /// </summary>
        [JsonProperty("seriesName")]
        public string SeriesName { get; private set; }
    }
}