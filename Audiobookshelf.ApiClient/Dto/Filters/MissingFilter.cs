using System;

namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after an atttribute that is missing.
    /// </summary>
    public class MissingFilter : IFilter
	{
        private readonly MissingValue _value;

        /// <summary>
        /// Creates a new instance of the missing filter with the missing value to filter.
        /// </summary>
        /// <param name="missingValue">The missing value to filter for.</param>
		public MissingFilter(MissingValue missingValue)
		{
            _value = missingValue;
		}

        public string ToFilterText()
        {
            return "missing." + Enum.GetName(typeof(MissingValue),_value).Base64AndUrlEncode();
        }
    }
}

