using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class SeriesSequence : SeriesBase
    {
        /// <summary>
        /// The position in the series the book is.
        /// </summary>
        [JsonProperty("sequence")]
        public string Sequence { get; private set; }
    }
}