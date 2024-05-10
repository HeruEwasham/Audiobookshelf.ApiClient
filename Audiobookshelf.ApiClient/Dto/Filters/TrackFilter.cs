using System;

namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after track.
    /// </summary>
    public class TrackFilter : IFilter
	{
        private readonly TrackValue _value;

        /// <summary>
        /// Creates a new instance of the track filter with the track value to filter.
        /// </summary>
        /// <param name="trackValue">The track value to filter for.</param>
		public TrackFilter(TrackValue trackValue)
		{
            _value = trackValue;
		}

        public string ToFilterText()
        {
            return "tracks." + Enum.GetName(typeof(TrackValue),_value).Base64AndUrlEncode();
        }
    }
}

