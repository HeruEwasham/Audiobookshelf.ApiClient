using System;
using System.Runtime.Serialization;

namespace Audiobookshelf.ApiClient.Dto
{
	public enum LibraryIcon
	{
		[EnumMember(Value = "database")]
		Database,
		[EnumMember(Value = "audiobookshelf")]
		Audiobookshelf,
		[EnumMember(Value = "books-1")]
		Books1,
		[EnumMember(Value = "books-2")]
		Books2,
		[EnumMember(Value = "book-1")]
		Book1,
		[EnumMember(Value = "microphone-1")]
		Microphone1,
		[EnumMember(Value = "microphone-3")]
		Microphone3,
		[EnumMember(Value = "radio")]
		Radio,
		[EnumMember(Value = "podcast")]
		Podcast,
		[EnumMember(Value = "rss")]
		Rss,
		[EnumMember(Value = "headphones")]
		Headphones,
		[EnumMember(Value = "music")]
		Music,
		[EnumMember(Value = "file-picture")]
		FilePicker,
		[EnumMember(Value = "rocket")]
		Rocket,
		[EnumMember(Value = "power")]
		Power,
		[EnumMember(Value = "star")]
		Star,
		[EnumMember(Value = "heart")]
		Heart
	}
}

