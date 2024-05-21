using Audiobookshelf.ApiClient.Dto;

namespace Audiobookshelf.ApiClient.Responses
{
    public class GetLibraryUserPlaylistsResponse<TLibraryItem> : LibraryResultsResponse<PlaylistExpanded<TLibraryItem>> { }
}

