using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class BookLibraryItemSeries : LibraryItem<Book>
    {
        /// <summary>
        /// denotes the position in the series the book is in, is tacked on.
        /// </summary>
        [JsonProperty("sequence")]
        public string Sequence { get; private set; }
    }
}

