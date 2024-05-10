using System;
using System.Net;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient.Responses
{
	public class Response<TResponseValue>
	{
		public bool IsSuccess
		{
            get { return ((int)StatusCode >= 200) && ((int)StatusCode <= 299); }
        }

		public HttpStatusCode StatusCode { get; }

		public TResponseValue Value { get; }

		public string ErrorMessage { get; }

		public Response(HttpStatusCode statusCode, string body, string mediaType)
		{
			StatusCode = statusCode;

			try
			{
                if (IsSuccess)
                {
					if (mediaType == "application/json")
					{
                        Value = JsonConvert.DeserializeObject<TResponseValue>(body);
                    }
					else if (mediaType == "text/plain" && (typeof(TResponseValue) == typeof(string) || typeof(TResponseValue) == typeof(object)))
					{
						Value = (TResponseValue)(object)body;
					}
                }
				else
				{
					ErrorMessage = body;
				}
            }
			catch (Exception e)
			{
				ErrorMessage = $"Got exception. Status Code is {statusCode}. Body is {body}. Exception message is {e.Message}";
				StatusCode = HttpStatusCode.Ambiguous;
			}
		}
	}
}

