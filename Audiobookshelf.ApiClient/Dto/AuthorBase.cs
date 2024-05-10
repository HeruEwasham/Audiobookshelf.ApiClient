using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public abstract class AuthorBase
    {
        /// <summary>
        /// The ID of the author.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the author.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
    }
}