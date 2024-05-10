namespace Audiobookshelf.ApiClient.Dto.Filters
{
    public class AuthorFilter : IFilter
	{
        private readonly string _authorId;

        /// <summary>
        /// Creates a new instance of the author filter with the author to filter.
        /// </summary>
        /// <param name="authorId">The author id to the author to filter around.</param>
		public AuthorFilter(string authorId)
		{
            _authorId = authorId;
		}

        public string ToFilterText()
        {
            return "authors." + _authorId.Base64AndUrlEncode();
        }
    }
}

