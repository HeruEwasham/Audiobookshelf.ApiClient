using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class SeriesBase
    {
        /// <summary>
        /// The ID of the series.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the series.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
    }
}