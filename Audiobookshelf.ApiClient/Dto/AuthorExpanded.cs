using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class AuthorExpanded : Author
	{
        /// <summary>
        /// The number of books associated with the author in the library.
        /// </summary>
        [JsonProperty("numBooks")]
        public int NumberOfBooks { get; private set; }
    }
}

