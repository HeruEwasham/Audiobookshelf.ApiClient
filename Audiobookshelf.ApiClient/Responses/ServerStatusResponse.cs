using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
    public class ServerStatusResponse
	{
        /// <summary>
        /// Whether the server has been initialized.
        /// </summary>
        [JsonProperty("isInit")]
		public bool IsInit { get; private set; }

        /// <summary>
        /// The server's default language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; private set; }

        /// <summary>
        /// The server's config path. Will only exist if isInit is false.
        /// </summary>
        [JsonProperty("ConfigPath")]
        public string ConfigPath { get; private set; }

        /// <summary>
        /// The server's metadata path. Will only exist if isInit is false.
        /// </summary>
        [JsonProperty("MetadataPath")]
        public string MetadataPath { get; private set; }
    }
}

