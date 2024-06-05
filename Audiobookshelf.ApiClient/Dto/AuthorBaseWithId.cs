using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class AuthorBaseWithId : AuthorBase
	{
        /// <summary>
        /// The ID of the author.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }
    }
}

