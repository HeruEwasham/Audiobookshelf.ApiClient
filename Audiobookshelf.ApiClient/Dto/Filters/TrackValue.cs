using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto.Filters
{
    public enum TrackValue
    {
        [EnumMember(Value = "single")]
        Single,
        [EnumMember(Value = "multi")]
        Multi
    }
}