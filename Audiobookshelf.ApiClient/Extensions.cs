using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Audiobookshelf.ApiClient.Responses;
using Newtonsoft.Json;

namespace Audiobookshelf.ApiClient
{
    internal static class Extensions
	{
		internal static async Task<Response<TResponseValue>> PostAsync<TResponseValue>(this HttpClient httpClient, string requestUri, object body)
		{
			HttpContent requestContent;
			if (body == null)
			{
				requestContent = new StringContent(string.Empty);
			}
			else
			{
                var json = JsonConvert.SerializeObject(body);
                requestContent = new StringContent(json, Encoding.UTF8, "application/json");
            }
			var response = httpClient.PostAsync(requestUri, requestContent).Result;
            var bodyResponse = await response.Content.ReadAsStringAsync();
            return new Response<TResponseValue>(response.StatusCode, bodyResponse, response.Content.Headers.ContentType?.MediaType);
        }

        internal static async Task<Response<TResponseValue>> PatchAsync<TResponseValue>(this HttpClient httpClient, string requestUri, object body)
        {
            HttpContent requestContent;
            if (body == null)
            {
                requestContent = new StringContent(string.Empty);
            }
            else
            {
                var json = JsonConvert.SerializeObject(body);
                requestContent = new StringContent(json, Encoding.UTF8, "application/json");
            }
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri);
            request.Content = requestContent;
            var response = httpClient.SendAsync(request).Result;
            var bodyResponse = await response.Content.ReadAsStringAsync();
            return new Response<TResponseValue>(response.StatusCode, bodyResponse, response.Content.Headers.ContentType?.MediaType);
        }

        internal static async Task<Response<TResponseValue>> PutAsync<TResponseValue>(this HttpClient httpClient, string requestUri, object body)
        {
            HttpContent requestContent;
            if (body == null)
            {
                requestContent = new StringContent(string.Empty);
            }
            else
            {
                var json = JsonConvert.SerializeObject(body);
                requestContent = new StringContent(json, Encoding.UTF8, "application/json");
            }
            var response = httpClient.PutAsync(requestUri, requestContent).Result;
            var bodyResponse = await response.Content.ReadAsStringAsync();
            return new Response<TResponseValue>(response.StatusCode, bodyResponse, response.Content.Headers.ContentType?.MediaType);
        }

        internal static async Task<Response<TResponseValue>> GetAsync<TResponseValue>(this HttpClient httpClient, string requestUri)
        {
            var response = httpClient.GetAsync(requestUri).Result;
            var bodyResponse = await response.Content.ReadAsStringAsync();
            return new Response<TResponseValue>(response.StatusCode, bodyResponse, response.Content.Headers.ContentType?.MediaType);
        }

        internal static async Task<Response<TResponseValue>> DeleteAsync<TResponseValue>(this HttpClient httpClient, string requestUri)
        {
            var response = httpClient.DeleteAsync(requestUri).Result;
            var bodyResponse = await response.Content.ReadAsStringAsync();
            return new Response<TResponseValue>(response.StatusCode, bodyResponse, response.Content.Headers.ContentType?.MediaType);
        }

        internal static int ToInt(this bool value)
        {
            return Convert.ToInt32(value);
        }
    }
}

