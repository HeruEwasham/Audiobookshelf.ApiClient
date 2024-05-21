using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto
{
    public enum ShelfType
    {
        [EnumMember(Value = "book")]
        Book,
        [EnumMember(Value = "series")]
        Series,
        [EnumMember(Value = "authors")]
        Authors,
        [EnumMember(Value = "episode")]
        Episode,
        [EnumMember(Value = "podcast")]
        Podcast
    }
}