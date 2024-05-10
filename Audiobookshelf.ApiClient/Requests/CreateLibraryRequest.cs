using System;
using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Requests
{
	public class CreateLibraryRequest : LibraryRequestBase
	{
        /// <summary>
        /// The type of media that the library contains. Must be book or podcast.
        /// </summary>
        [JsonProperty("mediaType")]
        public MediaType MediaType { get; set; }

        /// <summary>
        /// Create a new request with the minimum required info, and set all other to default.
        /// To change other settings, you can do that after providing the minimum required information.
        /// </summary>
        /// <param name="name">The name of the Library. This is required.</param>
        /// <param name="folders">The folders that the library has. This is required.</param>
        public CreateLibraryRequest(string name, Folder[] folders)
		{
            Name = name;
            Folders = folders;
            Icon = LibraryIcon.Database;
            Provider = MetadataProvider.GoogleBooks;
            Settings = new LibrarySettings();
            MediaType = MediaType.Book;
        }
	}
}

