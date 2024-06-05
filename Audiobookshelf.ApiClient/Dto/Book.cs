using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class Book : Book<BookMetadata> { }

    public abstract class Book<TBookMetadata> : BookBase<TBookMetadata> where TBookMetadata : BookMetadataBase
    {
        /// <summary>
        /// The ID of the library item that contains the book.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The book's audio files.
        /// </summary>
        [JsonProperty("audioFiles")]
        public AudioFile[] AudioFiles { get; private set; }

        /// <summary>
        /// The book's chapters.
        /// </summary>
        [JsonProperty("chapters")]
        public BookChapter[] Chapters { get; private set; }

        /// <summary>
        /// Any parts missing from the book by track index.
        /// </summary>
        [JsonProperty("missingParts")]
        public int[] MissingParts { get; private set; }

        /// <summary>
        /// The book's ebook file. Will be null if this is an audiobook.
        /// </summary>
        [JsonProperty("ebookFile")]
        public EbookFile EbookFile { get; private set; }
    }
}