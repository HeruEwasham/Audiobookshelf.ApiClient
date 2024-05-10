namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after narrator.
    /// </summary>
    public class NarratorFilter : IFilter
	{
        private readonly string _value;

        /// <summary>
        /// Creates a new instance of the narrator filter with the narrator to filter.
        /// </summary>
        /// <param name="narrator">The narrator to filter for.</param>
		public NarratorFilter(string narrator)
		{
            _value = narrator;
		}

        public string ToFilterText()
        {
            return "narrators." + _value.Base64AndUrlEncode();
        }
    }
}

