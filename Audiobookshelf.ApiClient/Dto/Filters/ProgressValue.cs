using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto.Filters
{
    public enum ProgressValue
    {
        [EnumMember(Value = "finished")]
        Finished,
        [EnumMember(Value = "not-started")]
        NotStarted,
        [EnumMember(Value = "not-finished")]
        NotFinished,
        [EnumMember(Value = "in-progress")]
        InProgress
    }
}