using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastEpisode
    {
        /// <summary>
        /// The ID of the library item that contains the podcast.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The ID of the podcast episode.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The index of the podcast episode.
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; private set; }

        /// <summary>
        /// The season of the podcast episode, if known.
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; private set; }

        /// <summary>
        /// The episode of the season of the podcast, if known.
        /// </summary>
        [JsonProperty("episode")]
        public string Episode { get; private set; }

        /// <summary>
        /// The type of episode that the podcast episode is.
        /// </summary>
        [JsonProperty("episodeType")]
        public string EpisodeType { get; private set; }

        /// <summary>
        /// The title of the podcast episode.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// The subtitle of the podcast episode.
        /// </summary>
        [JsonProperty("subtitle")]
        public string Subtitle { get; private set; }

        /// <summary>
        /// A HTML encoded, description of the podcast episode.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Information about the podcast episode from when it was downloaded.
        /// </summary>
        [JsonProperty("enclosure")]
        public PodcastEpisodeEnclosure Enclosure { get; private set; }

        /// <summary>
        /// When the podcast episode was published.
        /// </summary>
        [JsonProperty("pubDate")]
        public string PubDate { get; private set; }

        /// <summary>
        /// The audio file for the podcast episode.
        /// </summary>
        [JsonProperty("audioFile")]
        public AudioFile AudioFile { get; private set; }

        /// <summary>
        /// The time when the podcast episode was published.
        /// </summary>
        [JsonProperty("publishedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime PublishedAt { get; private set; }

        /// <summary>
        /// TThe time when the podcast episode was added to the library.
        /// </summary>
        [JsonProperty("addedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// The time when the podcast episode was last updated.
        /// </summary>
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime UpdatedAt { get; private set; }
    }
}