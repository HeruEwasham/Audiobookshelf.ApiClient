using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Requests
{
	internal class LogoutRequest
	{
        /// <summary>
        /// The ID of the connected socket.
        /// </summary>
        [JsonProperty("socketId")]
        public string SocketId { get; set; }
    }
}

