namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after series.
    /// </summary>
    public class SeriesFilter : IFilter
	{
        private readonly string _seriesId;

        /// <summary>
        /// Creates a new instance of the series filter with the series to filter.
        /// </summary>
        /// <param name="seriesId">The series id to the series to filter around.</param>
		public SeriesFilter(string seriesId)
		{
            _seriesId = seriesId;
		}

        public string ToFilterText()
        {
            return "series." + _seriesId.Base64AndUrlEncode();
        }
    }
}

