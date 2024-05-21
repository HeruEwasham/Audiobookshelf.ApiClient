using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class BookMinifiedWithSeriesSequence : BookMinified
	{
        /// <summary>
        /// The position of the book in the series.
        /// </summary>
        [JsonProperty("seriesSequence")]
        public string SeriesSequence { get; private set; }
    }
}

