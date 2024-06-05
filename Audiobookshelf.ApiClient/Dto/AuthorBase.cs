using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class AuthorBase
    {
        /// <summary>
        /// The name of the author.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}