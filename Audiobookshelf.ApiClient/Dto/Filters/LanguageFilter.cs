namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after language.
    /// </summary>
    public class LanguageFilter : IFilter
	{
        private readonly string _value;

        /// <summary>
        /// Creates a new instance of the language filter with the language to filter.
        /// </summary>
        /// <param name="language">The language to filter for.</param>
		public LanguageFilter(string language)
		{
            _value = language;
		}

        public string ToFilterText()
        {
            return "languages." + _value.Base64AndUrlEncode();
        }
    }
}

