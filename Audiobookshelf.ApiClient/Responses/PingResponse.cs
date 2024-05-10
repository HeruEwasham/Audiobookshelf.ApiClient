using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class PingResponse
	{
        /// <summary>
        /// Whether the server has been initialized.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; private set; }
    }
}

