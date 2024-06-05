using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto
{
    public enum ImageFormat
	{
        [EnumMember(Value = "webp")]
        WebP,
        [EnumMember(Value = "jpeg")]
        Jpeg
    }
}

