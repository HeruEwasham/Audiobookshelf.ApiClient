using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class PodcastEpisodeExpanded : PodcastEpisode
	{
        /// <summary>
        /// The podcast episode's audio tracks from the audio file.
        /// </summary>
        [JsonProperty("audioTrack")]
        public AudioTrack AudioTrack { get; private set; }

        /// <summary>
        /// The total length of the podcast episode.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// The total size (in bytes) of the podcast episode.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; private set; }
    }
}

