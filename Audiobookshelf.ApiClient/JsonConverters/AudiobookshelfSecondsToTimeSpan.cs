using System;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.JsonConverters
{
    public class AudiobookshelfSecondsToTimeSpan : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(TimeSpan) == objectType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            return TimeSpan.FromSeconds((double)reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((TimeSpan)value).TotalSeconds);
        }
    }
}

