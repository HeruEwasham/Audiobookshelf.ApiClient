using System;
using System.Web;

namespace Audiobookshelf.ApiClient.Dto.Filters
{
	internal static class Extensions
	{
		internal static string Base64AndUrlEncode(this string value)
		{
			return HttpUtility.UrlEncode(Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value)));
		}
	}
}

