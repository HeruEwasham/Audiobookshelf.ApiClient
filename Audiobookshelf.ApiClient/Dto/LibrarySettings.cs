using System;
using Audiobookshelf.ApiClient.JsonConverters;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
	public class LibrarySettings
	{
        public LibrarySettings(bool coverAspectRatio = true, bool disableWatcher = false, bool skipMatchingMediaWithAsin = false, bool skipMatchingMediaWithIsbn = false, string autoScanCronExpression = null)
        {
            CoverAspectRatio = coverAspectRatio;
            DisableWatcher = disableWatcher;
            SkipMatchingMediaWithAsin = skipMatchingMediaWithAsin;
            SkipMatchingMediaWithIsbn = skipMatchingMediaWithIsbn;
            AutoScanCronExpression = autoScanCronExpression;
        }

        /// <summary>
        /// Whether the library should use square book covers.
        /// </summary>
        [JsonProperty("coverAspectRatio")]
		[JsonConverter(typeof(BoolToFromIntConverter))]
		public bool CoverAspectRatio { get; private set; }

        /// <summary>
        /// Whether to disable the folder watcher for the library.
        /// </summary>
        [JsonProperty("disableWatcher")]
        public bool DisableWatcher { get; private set; }

        /// <summary>
        /// Whether to skip matching books that already have an ASIN.
        /// </summary>
        [JsonProperty("skipMatchingMediaWithAsin")]
        public bool SkipMatchingMediaWithAsin { get; private set; }

        /// <summary>
        /// Whether to skip matching books that already have an ISBN.
        /// </summary>
        [JsonProperty("skipMatchingMediaWithIsbn")]
        public bool SkipMatchingMediaWithIsbn { get; private set; }

        /// <summary>
        /// The cron expression for when to automatically scan the library folders. If null, automatic scanning will be disabled.
        /// </summary>
        [JsonProperty("autoScanCronExpression")]
        public string AutoScanCronExpression { get; private set; }
    }
}

