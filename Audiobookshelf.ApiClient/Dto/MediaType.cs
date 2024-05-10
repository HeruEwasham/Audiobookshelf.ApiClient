using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto
{
    public enum MediaType
    {
        [EnumMember(Value = "book")]
        Book,
        [EnumMember(Value = "podcast")]
        Podcast
    }
}