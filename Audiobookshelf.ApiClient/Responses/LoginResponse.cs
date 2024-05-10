using Audiobookshelf.ApiClient.Dto;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class LoginResponse
	{
        /// <summary>
        /// The authenticated user.
        /// </summary>
        [JsonProperty("user")]
		public User User { get; private set; }

        /// <summary>
        /// The ID of the first library in the list the user has access to.
        /// </summary>
        [JsonProperty("userDefaultLibraryId")]
		public string UserDefaultLibraryId { get; private set; }

        /// <summary>
        /// The server's settings.
        /// </summary>
		[JsonProperty("serverSettings")]
		public ServerSettings ServerSettings { get; private set; }

        /// <summary>
        /// The server's installation source.
        /// </summary>
		[JsonProperty("Source")]
		public string Source { get; private set; }
    }
}

