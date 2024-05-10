﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Audiobookshelf.ApiClient.JsonConverters
{
	public class AudiobookshelfDateTimeConverter : DateTimeConverterBase
	{
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(((DateTime)value - _epoch).TotalMilliseconds.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            return _epoch.AddMilliseconds(Convert.ToDouble(reader.Value));
        }
    }
}
