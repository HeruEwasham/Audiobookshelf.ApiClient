using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Dto
{
    /// <summary>
    /// ID3 metadata tags pulled from the audio file on import.
    /// </summary>
    public class AudioMetaTags
    {
        [JsonProperty("tagAlbum")]
        public string TagAlbum { get; private set; }

        [JsonProperty("tagArtist")]
        public string TagArtist { get; private set; }

        [JsonProperty("tagGenre")]
        public string TagGenre { get; private set; }

        [JsonProperty("tagTitle")]
        public string TagTitle { get; private set; }

        [JsonProperty("tagSeries")]
        public string TagSeries { get; private set; }

        [JsonProperty("tagSeriesPart")]
        public string TagSeriesPart { get; private set; }

        [JsonProperty("tagTrack")]
        public string TagTrack { get; private set; }

        [JsonProperty("tagDisc")]
        public string TagDisc { get; private set; }

        [JsonProperty("tagSubtitle")]
        public string TagSubtitle { get; private set; }

        [JsonProperty("tagAlbumArtist")]
        public string TagAlbumArtist { get; private set; }

        [JsonProperty("tagDate")]
        public string TagDate { get; private set; }

        [JsonProperty("tagComposer")]
        public string TagComposer { get; private set; }

        [JsonProperty("tagPublisher")]
        public string TagPublisher { get; private set; }

        [JsonProperty("tagComment")]
        public string TagComment { get; private set; }

        [JsonProperty("tagDescription")]
        public string TagDescription { get; private set; }

        [JsonProperty("tagEncoder")]
        public string TagEncoder { get; private set; }

        [JsonProperty("tagEncodedBy")]
        public string TagEncodedBy { get; private set; }

        [JsonProperty("tagIsbn")]
        public string TagIsbn { get; private set; }

        [JsonProperty("tagLanguage")]
        public string TagLanguage { get; private set; }

        [JsonProperty("tagASIN")]
        public string TagAsin { get; private set; }

        [JsonProperty("tagOverdriveMediaMarker")]
        public string TagOverdriveMediaMarker { get; private set; }

        [JsonProperty("tagOriginalYear")]
        public string TagOriginalYear { get; private set; }

        [JsonProperty("tagReleaseCountry")]
        public string TagReleaseCountry { get; private set; }

        [JsonProperty("tagReleaseType")]
        public string TagReleaseType { get; private set; }

        [JsonProperty("tagReleaseStatus")]
        public string TagReleaseStatus { get; private set; }

        [JsonProperty("tagISRC")]
        public string TagIsrc { get; private set; }

        [JsonProperty("tagMusicBrainzTrackId")]
        public string TagMusicBrainzTrackId { get; private set; }

        [JsonProperty("tagMusicBrainzAlbumId")]
        public string TagMusicBrainzAlbumId { get; private set; }

        [JsonProperty("tagMusicBrainzAlbumArtistId")]
        public string TagMusicBrainzAlbumArtistId { get; private set; }

        [JsonProperty("tagMusicBrainzArtistId")]
        public string TagMusicBrainzArtistId { get; private set; }
    }
}