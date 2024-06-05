using Audiobookshelf.ApiClient.JsonConverters;
using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class PodcastBase<TPodcastMetadata> where TPodcastMetadata : PodcastMetadata
    {
        /// <summary>
        /// The metadata for the podcast.
        /// </summary>
        [JsonProperty("metadata")]
        public TPodcastMetadata Metadata { get; private set; }

        /// <summary>
        /// The absolute path on the server of the cover file. Will be null if there is no cover.
        /// </summary>
        [JsonProperty("coverPath")]
        public string CoverPath { get; private set; }

        /// <summary>
        /// The podcast's tags.
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; private set; }

        /// <summary>
        /// Whether the server will automatically download podcast episodes according to the schedule.
        /// </summary>
        [JsonProperty("autoDownloadEpisodes")]
        public bool AutoDownloadEpisodes { get; private set; }

        /// <summary>
        /// The cron expression for when to automatically download podcast episodes. Will not exist if autoDownloadEpisodes is false.
        /// </summary>
        [JsonProperty("autoDownloadSchedule")]
        public string AutoDownloadSchedule { get; private set; }

        /// <summary>
        /// The time when the podcast was checked for new episodes.
        /// </summary>
        [JsonProperty("lastEpisodeCheck")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime LastEpisodeCheck { get; private set; }

        /// <summary>
        /// The maximum number of podcast episodes to keep when automatically downloading new episodes. Episodes beyond this limit will be deleted. If 0, all episodes will be kept.
        /// </summary>
        [JsonProperty("maxEpisodesToKeep")]
        public int MaxEpisodesToKeep { get; private set; }

        /// <summary>
        /// The maximum number of podcast episodes to download when automatically downloading new episodes. If 0, all episodes will be downloaded.
        /// </summary>
        [JsonProperty("maxNewEpisodesToDownload")]
        public int MaxNewEpisodesToDownload { get; private set; }
    }
}