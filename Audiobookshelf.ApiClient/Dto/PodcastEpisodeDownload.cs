using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastEpisodeDownload
	{
        /// <summary>
        /// The ID of the podcast episode download.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The display title of the episode to be downloaded.
        /// </summary>
        [JsonProperty("episodeDisplayTitle")]
        public string EpisodeDisplayTitle { get; private set; }

        /// <summary>
        /// The URL from which to download the episode.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; private set; }

        /// <summary>
        /// The ID of the library item the episode belongs to.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The ID of the library the episode's podcast belongs to.
        /// </summary>
        [JsonProperty("libraryId")]
        public string LibraryId { get; private set; }

        /// <summary>
        /// Whether the episode has finished downloading.
        /// </summary>
        [JsonProperty("isFinished")]
        public bool IsFinished { get; private set; }

        /// <summary>
        /// Whether the episode failed to download.
        /// </summary>
        [JsonProperty("failed")]
        public bool Failed { get; private set; }

        /// <summary>
        /// The time when the episode started downloading. Will be null if it has not started downloading yet.
        /// </summary>
        [JsonProperty("startedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime? StartedAt { get; private set; }

        /// <summary>
        /// The time when the podcast episode download request was created.
        /// </summary>
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// The time when the episode finished downloading. Will be null if it has not finished.
        /// </summary>
        [JsonProperty("finishedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime? FinishedAt { get; private set; }

        /// <summary>
        /// The title of the episode's podcast.
        /// </summary>
        [JsonProperty("podcastTitle")]
        public string PodcastTitle { get; private set; }

        /// <summary>
        /// Whether the episode's podcast is explicit.
        /// </summary>
        [JsonProperty("podcastExplicit")]
        public bool PodcastExplicit { get; private set; }

        /// <summary>
        /// The season of the podcast episode.
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; private set; }

        /// <summary>
        /// The episode number of the podcast episode.
        /// </summary>
        [JsonProperty("episode")]
        public string Episode { get; private set; }

        /// <summary>
        /// The type of the podcast episode.
        /// </summary>
        [JsonProperty("episodeType")]
        public string EpisodeType { get; private set; }

        /// <summary>
        /// The time when the episode was published.
        /// </summary>
        [JsonProperty("publishedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime PublishedAt { get; private set; }
    }
}

