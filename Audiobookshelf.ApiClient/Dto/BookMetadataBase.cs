using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class BookMetadataBase
    {
        /// <summary>
        /// The title of the book. Will be null if unknown.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The subtitle of the book. Will be null if there is no subtitle.
        /// </summary>
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// The genres of the book.
        /// </summary>
        [JsonProperty("genres")]
        public string[] Genres { get; set; }

        /// <summary>
        /// The year the book was published. Will be null if unknown.
        /// </summary>
        [JsonProperty("publishedYear")]
        public string PublishedYear { get; set; }

        /// <summary>
        /// The date the book was published. Will be null if unknown.
        /// </summary>
        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        /// <summary>
        /// The publisher of the book. Will be null if unknown.
        /// </summary>
        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// A description for the book. Will be null if empty.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ISBN of the book. Will be null if unknown.
        /// </summary>
        [JsonProperty("isbn")]
        public string Isbn { get; set; }

        /// <summary>
        /// The ASIN of the book. Will be null if unknown.
        /// </summary>
        [JsonProperty("asin")]
        public string Asin { get; set; }

        /// <summary>
        /// The language of the book. Will be null if unknown.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Whether the book has been marked as explicit.
        /// </summary>
        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

        /// <summary>
        /// Whether the book has been marked as abridged.
        /// </summary>
        [JsonProperty("abridged")]
        public bool Abridged { get; set; }
    }
}