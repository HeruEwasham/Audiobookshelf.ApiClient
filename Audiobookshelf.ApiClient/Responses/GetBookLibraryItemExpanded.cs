using Audiobookshelf.ApiClient.Dto;

namespace Audiobookshelf.ApiClient.Responses
{
    public class GetBookLibraryItemExpanded : GetLibraryItemExpanded<BookMetadataExpanded<Author, SeriesSequence>> { }
}

