using System;
namespace Audiobookshelf.ApiClient.Dto
{
	public class PlaylistExpanded<TLibraryItem> : Playlist<PlaylistItemExpanded<TLibraryItem>> { }
}

