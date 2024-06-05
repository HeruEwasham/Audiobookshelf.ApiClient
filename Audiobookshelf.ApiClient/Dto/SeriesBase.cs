using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class SeriesBase
    {
        /// <summary>
        /// The name of the series.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}