using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto.Filters
{
    public enum MissingValue
    {
        [EnumMember(Value = "asin")]
        Asin,
        [EnumMember(Value = "isbn")]
        Isbn,
        [EnumMember(Value = "subtitle")]
        Subtitle,
        [EnumMember(Value = "authors")]
        Authors,
        [EnumMember(Value = "publishedYear")]
        PublishedYear,
        [EnumMember(Value = "series")]
        Series,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "genres")]
        Genres,
        [EnumMember(Value = "tags")]
        Tags,
        [EnumMember(Value = "narrators")]
        Narrators,
        [EnumMember(Value = "publisher")]
        Publisher,
        [EnumMember(Value = "language")]
        Language
    }
}