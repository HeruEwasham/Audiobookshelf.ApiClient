using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Requests
{
	internal class LoginRequest
	{
        /// <summary>
        /// The username to log in with.
        /// </summary>
        [JsonProperty("username")]
		public string Username { get; set; }

        /// <summary>
        /// The password of the user.
        /// </summary>
        [JsonProperty("password")]
		public string Password { get; set; }
	}
}

