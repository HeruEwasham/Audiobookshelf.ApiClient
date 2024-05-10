namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after tag.
    /// </summary>
    public class TagFilter : IFilter
	{
        private readonly string _tag;

        /// <summary>
        /// Creates a new instance of the tag filter with the tag to filter.
        /// </summary>
        /// <param name="tag">The tag to filter around.</param>
		public TagFilter(string tag)
		{
            _tag = tag;
		}

        public string ToFilterText()
        {
            return "tags." + _tag.Base64AndUrlEncode();
        }
    }
}

