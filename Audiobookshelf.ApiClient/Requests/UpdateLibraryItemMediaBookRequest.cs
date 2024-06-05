using System.Linq;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Requests
{
    public class UpdateLibraryItemMediaBookRequest
	{
        /// <summary>
        /// The book's metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public BookMetadata<AuthorBase, SeriesSequenceWithoutId> Metadata { get; set; }

        /// <summary>
        /// The absolute path on the server of the cover file. Use null to remove the cover. Prefer using the Update a Library Item's Cover endpoint.
        /// </summary>
        [JsonProperty("coverPath")]
        public string CoverPath { get; set; }

        /// <summary>
        /// The book's tags.
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// The book's tags.
        /// </summary>
        [JsonProperty("chapters")]
        public BookChapter[] Chapters { get; set; }

        public static UpdateLibraryItemMediaBookRequest CreateFromLibraryItem(LibraryItem<Book> libraryItem)
        {
            return CreateFromBook(libraryItem.Media);
        }

        public static UpdateLibraryItemMediaBookRequest CreateFromBook(Book book)
        {
            return new UpdateLibraryItemMediaBookRequest
            {
                Metadata = new BookMetadata<AuthorBase, SeriesSequenceWithoutId>
                {
                    Title = book.Metadata.Title,
                    Subtitle = book.Metadata.Subtitle,
                    Authors = book.Metadata.Authors,
                    Narrators = book.Metadata.Narrators,
                    Series = book.Metadata.Series.Select(s => new SeriesSequenceWithoutId
                    {
                        Name = s.Name,
                        Sequence = s.Sequence
                    }).ToArray(),
                    Genres = book.Metadata.Genres,
                    PublishedYear = book.Metadata.PublishedYear,
                    PublishedDate = book.Metadata.PublishedDate,
                    Publisher = book.Metadata.Publisher,
                    Description = book.Metadata.Description,
                    Isbn = book.Metadata.Isbn,
                    Asin = book.Metadata.Asin,
                    Language = book.Metadata.Language,
                    Explicit = book.Metadata.Explicit,
                    Abridged = book.Metadata.Abridged
                },
                CoverPath = book.CoverPath,
                Tags = book.Tags,
                Chapters = book.Chapters
            };
        }
    }
}

