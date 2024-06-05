using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class SeriesBaseWithId : SeriesBase
	{
        /// <summary>
        /// The ID of the series.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }
    }
}

