using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class MediaProgress
    {

        /// <summary>
        /// The ID of the media progress. If the media progress is for a book, this will just be the libraryItemId. If for a podcast episode, it will be a hyphenated combination of the libraryItemId and episodeId.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The ID of the library item the media progress is of.
        /// </summary>
        [JsonProperty("libraryItemId")]
        public string LibraryItemId { get; private set; }

        /// <summary>
        /// The ID of the podcast episode the media progress is of. Will be null if the progress is for a book.
        /// </summary>
        [JsonProperty("episodeId")]
        public string EpisodeId { get; private set; }

        /// <summary>
        /// The total duration of the media. Will be 0 if the media was marked as finished without the user listening to it.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// The percentage completion progress of the media. Will be 1 if the media is finished.
        /// </summary>
        [JsonProperty("progress")]
        public float Progress { get; private set; }

        /// <summary>
        /// The current time of the user's progress. If the media has been marked as finished, this will be the time the user was at beforehand.
        /// </summary>
        [JsonProperty("currentTime")]
        [JsonConverter(typeof(AudiobookshelfSecondsToTimeSpan))]
        public TimeSpan CurrentTime { get; private set; }

        /// <summary>
        /// Whether the media is finished.
        /// </summary>
        [JsonProperty("isFinished")]
        public bool IsFinished { get; private set; }

        /// <summary>
        /// Whether the media will be hidden from the "Continue Listening" shelf.
        /// </summary>
        [JsonProperty("hideFromContinueListening")]
        public bool HideFromContinueListening { get; private set; }

        /// <summary>
        /// The time when the media progress was last updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime LastUpdate { get; private set; }

        /// <summary>
        /// The time when the media progress was created.
        /// </summary>
        [JsonProperty("startedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime StartedAt { get; private set; }

        /// <summary>
        /// The time when the media was finished. Will be null if the media has is not finished.
        /// </summary>
        [JsonProperty("finishedAt")]
        [JsonConverter(typeof(AudiobookshelfDateTimeConverter))]
        public DateTime? FinishedAt { get; private set; }
    }
}