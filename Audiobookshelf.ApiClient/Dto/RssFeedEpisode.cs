using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class RssFeedEpisode
    {
        /// <summary>
        /// The ID of the RSS feed episode.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The title of the RSS feed episode.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// An HTML encoded description of the RSS feed episode.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Download information for the RSS feed episode.
        /// </summary>
        [JsonProperty("enclosure")]
        public PodcastEpisodeEnclosure Enclosure { get; private set; }

        /// <summary>
        /// The RSS feed episode's publication date.
        /// </summary>
        [JsonProperty("pubDate")]
        public DateTime PubDate { get; private set; }

        /// <summary>
        /// A URL to display to the RSS feed user.
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; private set; }

        /// <summary>
        /// The author of the RSS feed episode.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; private set; }

        /// <summary>
        /// Whether the RSS feed episode is explicit.
        /// </summary>
        [JsonProperty("explicit")]
        public bool Explicit { get; private set; }

        /// <summary>
        /// The duration of the RSS feed episode.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// The season of the RSS feed episode.
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; private set; } = null;

        /// <summary>
        /// The episode number of the RSS feed episode.
        /// </summary>
        [JsonProperty("episode")]
        public int? Episode { get; private set; } = null;

        /// <summary>
        /// The type of the RSS feed episode.
        /// </summary>
        [JsonProperty("episodeType")]
        public string EpisodeType { get; private set; } = null;

        /// <summary>
        /// The ID of the library item the RSS feed is for.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The ID of the podcast episode the RSS feed episode is for. Will be null if the RSS feed is for a book.
        /// </summary>
        [JsonProperty("episodeId")]
        public string EpisodeId { get; private set; } = null;

        /// <summary>
        /// The RSS feed episode's track index.
        /// </summary>
        [JsonProperty("trackIndex")]
        public int TrackIndex { get; private set; }

        /// <summary>
        /// The path on the server of the audio file the RSS feed episode is for.
        /// </summary>
        [JsonProperty("fullPath")]
        public string FullPath { get; private set; }
    }
}