using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    public class ServerSettings
    {
        /// <summary>
        /// The ID of the server settings.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Whether the scanner will attempt to find a cover if your audiobook does not have an embedded cover or a cover image inside the folder. Note: This will extend scan time.
        /// </summary>
        [JsonProperty("scannerFindCovers")]
        public bool ScannerFindCovers { get; private set; }

        /// <summary>
        /// If scannerFindCovers is true, which metadata provider to use.
        /// </summary>
        [JsonProperty("scannerCoverProvider")]
        public MetadataProvider ScannerCoverProvider { get; private set; }

        /// <summary>
        /// Whether to extract subtitles from audiobook folder names. Subtitles must be separated by -, i.e. /audiobooks/Book Title - A Subtitle Here/ has the subtitle A Subtitle Here.
        /// </summary>
        [JsonProperty("scannerParseSubtitle")]
        public bool ScannerParseSubtitle { get; private set; }

        /// <summary>
        /// Whether to use audio file ID3 meta tags instead of folder names for book details.
        /// </summary>
        [JsonProperty("scannerPreferAudioMetadata")]
        public bool ScannerPreferAudioMetadata { get; private set; }

        /// <summary>
        /// Whether to use OPF file metadata instead of folder names for book details.
        /// </summary>
        [JsonProperty("scannerPreferOpfMetadata")]
        public bool ScannerPreferOpfMetadata { get; private set; }

        /// <summary>
        /// Whether matched data will override item details when using Quick Match. By default, Quick Match will only fill in missing details.
        /// </summary>
        [JsonProperty("scannerPreferMatchedMetadata")]
        public bool ScannerPreferMatchedMetadata { get; private set; }

        /// <summary>
        /// Whether to disable the automatic adding/updating of items when file changes are detected. Requires server restart for changes to take effect.
        /// </summary>
        [JsonProperty("scannerDisableWatcher")]
        public bool ScannerDisableWatcher { get; private set; }

        /// <summary>
        /// Whether to use the custom metadata in MP3 files from Overdrive for chapter timings automatically.
        /// </summary>
        [JsonProperty("scannerPreferOverdriveMediaMarker")]
        public bool ScannerPreferOverdriveMediaMarker { get; private set; }

        /// <summary>
        /// Whether to store covers in the library item's folder. By default, covers are stored in /metadata/items. Only one file named cover will be kept.
        /// </summary>
        [JsonProperty("storeCoverWithItem")]
        public bool StoreCoverWithItem { get; private set; }

        /// <summary>
        /// Whether to store metadata files in the library item's folder. By default, metadata files are stored in /metadata/items. Uses the .abs file extension.
        /// </summary>
        [JsonProperty("storeMetadataWithItem")]
        public bool StoreMetadataWithItem { get; private set; }

        /// <summary>
        /// Must be either json or abs
        /// </summary>
        [JsonProperty("metadataFileFormat")]
        public string MetadataFileFormat { get; private set; }

        /// <summary>
        /// The maximum number of login requests per rateLimitLoginWindow.
        /// </summary>
        [JsonProperty("rateLimitLoginRequests")]
        public int RateLimitLoginRequests { get; private set; }

        /// <summary>
        /// The length (in ms) of each login rate limit window.
        /// </summary>
        [JsonProperty("rateLimitLoginWindow")]
        public int RateLimitLoginWindow { get; private set; }

        /// <summary>
        /// The cron expression for when to do automatic backups.
        /// </summary>
        [JsonProperty("backupSchedule")]
        public string BackupSchedule { get; private set; }

        /// <summary>
        /// The number of backups to keep.
        /// </summary>
        [JsonProperty("backupsToKeep")]
        public int BackupsToKeep { get; private set; }

        /// <summary>
        /// The maximum backup size (in GB) before they fail, a safeguard against misconfiguration.
        /// </summary>
        [JsonProperty("maxBackupSize")]
        public int MaxBackupSize { get; private set; }

        /// <summary>
        /// Whether backups should include library item covers and author images located in metadata.
        /// </summary>
        [JsonProperty("backupMetadataCovers")]
        public bool BackupMetadataCovers { get; private set; }

        /// <summary>
        /// The number of daily logs to keep.
        /// </summary>
        [JsonProperty("loggerDailyLogsToKeep")]
        public int LoggerDailyLogsToKeep { get; private set; }

        /// <summary>
        /// The number of scanner logs to keep.
        /// </summary>
        [JsonProperty("loggerScannerLogsToKeep")]
        public int LoggerScannerLogsToKeep { get; private set; }

        /// <summary>
        /// Whether the home page should use a skeuomorphic design with wooden shelves.
        /// </summary>
        [JsonProperty("homeBookshelfView")]
        public int HomeBookshelfView { get; private set; }

        /// <summary>
        /// Whether other bookshelf pages should use a skeuomorphic design with wooden shelves.
        /// </summary>
        [JsonProperty("bookshelfView")]
        public int BookshelfView { get; private set; }

        /// <summary>
        /// Whether to ignore prefixes when sorting. For example, for the prefix the, the book title The Book Title would sort as Book Title, The.
        /// </summary>
        [JsonProperty("sortingIgnorePrefix")]
        public bool SortingIgnorePrefix { get; private set; }

        /// <summary>
        /// If sortingIgnorePrefix is true, what prefixes to ignore.
        /// </summary>
        [JsonProperty("sortingPrefixes")]
        public string[] SortingPrefixes { get; private set; }

        /// <summary>
        /// Whether to enable streaming to Chromecast devices.
        /// </summary>
        [JsonProperty("chromecastEnabled")]
        public bool ChromecastEnabled { get; private set; }

        /// <summary>
        /// What date format to use. Options are MM/dd/yyyy, dd/MM/yyyy, dd.MM.yyyy, yyyy-MM-dd, MMM do, yyyy, MMMM do, yyyy, dd MMM yyyy, or dd MMMM yyyy.
        /// </summary>
        [JsonProperty("dateFormat")]
        public string DateFormat { get; private set; }

        /// <summary>
        /// What time format to use. Options are HH:mm (24-hour) and h:mma (am/pm).
        /// </summary>
        [JsonProperty("timeFormat")]
        public string TimeFormat { get; private set; }

        /// <summary>
        /// The default server language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; private set; }

        /// <summary>
        /// What log level the server should use when logging. 1 for debug, 2 for info, or 3 for warnings.
        /// </summary>
        [JsonProperty("logLevel")]
        public int LogLevel { get; private set; }

        /// <summary>
        /// The server's version.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; private set; }
    }
}