namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after genre.
    /// </summary>
    public class GenreFilter : IFilter
	{
        private readonly string _genre;

        /// <summary>
        /// Creates a new instance of the genre filter with the genre to filter.
        /// </summary>
        /// <param name="genre">The genre to filter for.</param>
		public GenreFilter(string genre)
		{
            _genre = genre;
		}

        public string ToFilterText()
        {
            return "genres." + _genre.Base64AndUrlEncode();
        }
    }
}

