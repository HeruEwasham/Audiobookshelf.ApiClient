using System;

namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after progress status.
    /// </summary>
    public class ProgressFilter : IFilter
	{
        private readonly ProgressValue _value;

        /// <summary>
        /// Creates a new instance of the progress filter with the progress to filter.
        /// </summary>
        /// <param name="progress">The progress to filter for.</param>
		public ProgressFilter(ProgressValue progress)
		{
            _value = progress;
		}

        public string ToFilterText()
        {
            return "progress." + Enum.GetName(typeof(ProgressValue),_value).Base64AndUrlEncode();
        }
    }
}

