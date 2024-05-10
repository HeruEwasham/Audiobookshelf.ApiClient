using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Audiobookshelf.ApiClient.Dto;
using Audiobookshelf.ApiClient.Dto.Filters;
using Audiobookshelf.ApiClient.Requests;
using Audiobookshelf.ApiClient.Responses;

namespace Audiobookshelf.ApiClient
{
    public class AudiobookshelfApiClient
    {
        private HttpClient _httpClient;

        /// <summary>
        /// Creates a new client based on the given parameters.
        /// </summary>
        /// <param name="baseUrl">The url to the server to connect to. Eks. https://abs.example.com</param>
        /// <param name="httpClient">An instance of the httpClient to use. Mark that the BaseAddress wil be set to baseUrl given.</param>
        public AudiobookshelfApiClient(Uri baseUrl, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseUrl;
        }

        /// <summary>
        /// Creates a new client based on the given parameters.
        /// </summary>
        /// <param name="baseUrl">The url to the server to connect to. Eks. https://abs.example.com</param>
        /// <param name="httpClient">An instance of the httpClient to use. Mark that the BaseAddress wil be set to baseUrl given.</param>
        public AudiobookshelfApiClient(string baseUrl, HttpClient httpClient) : this(new Uri(baseUrl), httpClient) { }

        /// <summary>
        /// Creates a new client based on the given parameters.
        /// </summary>
        /// <param name="baseUrl">The url to the server to connect to. Eks. https://abs.example.com</param>
        public AudiobookshelfApiClient(Uri baseUrl) : this(baseUrl, new HttpClient()) { }

        /// <summary>
        /// Creates a new client based on the given parameters.
        /// </summary>
        /// <param name="baseUrl">The url to the server to connect to. Eks. https://abs.example.com</param>
        public AudiobookshelfApiClient(string baseUrl) : this(baseUrl, new HttpClient()) { }

        #region Server
        /// <summary>
        /// This endpoint logs in a client to the server, returning information about the user and server.
        /// If successful the api token will also be set so you can use all the other endpoints where you need to be logged in.
        /// </summary>
        /// <param name="username">The username to log in with.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns></returns>
        public async Task<Response<LoginResponse>> Login(string username, string password)
        {
            var result = await _httpClient.PostAsync<LoginResponse>("/login", new LoginRequest
            {
                Username = username,
                Password = password
            });

            if (result.IsSuccess)
            {
                SetApiToken(result.Value.User.Token);
            }

            return result;
        }

        /// <summary>
        /// This will set the given token to use for authentication.
        /// The token is automatically added if you call the login-method, but if you have a valid token you can use this to authenticate.
        /// </summary>
        /// <param name="token">The api token to use.</param>
        public void SetApiToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        /// <summary>
        /// This endpoint logs out a client from the server. If the socketId parameter is provided, the server removes the socket from the client list. When using a socket connection this allows a client to change the user without needing to re-create the socket connection.
        /// </summary>
        /// <param name="socketId">The ID of the connected socket.</param>
        /// <returns></returns>
        public async Task<Response<string>> Logout(string socketId = null)
        {
            LogoutRequest logoutRequest = null;
            if (socketId != null)
            {
                logoutRequest = new LogoutRequest
                {
                    SocketId = socketId
                };
            }
            var response = await _httpClient.PostAsync<string>("/logout", logoutRequest);
            if (response.IsSuccess)
            {
                _httpClient.DefaultRequestHeaders.Authorization = null;
            }
            return response;
        }

        /// <summary>
        /// This endpoint reports the server's initialization status.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<ServerStatusResponse>> GetServerStatus()
        {
            return await _httpClient.GetAsync<ServerStatusResponse>("/status");
        }

        /// <summary>
        /// This endpoint is a simple check to see if the server is operating and responding with JSON correctly.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<PingResponse>> Ping()
        {
            return await _httpClient.GetAsync<PingResponse>("/ping");
        }

        /// <summary>
        /// This endpoint is a simple check to see if the server is operating and can respond.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<string>> Healthcheck()
        {
            return await _httpClient.GetAsync<string>("/healthcheck");
        }
        #endregion

        #region Libraries
        /// <summary>
        /// This endpoint creates a library with the specified options.
        /// </summary>
        /// <param name="request">The options.</param>
        /// <returns></returns>
        public async Task<Response<Library>> CreateLibrary(CreateLibraryRequest request)
        {
            return await _httpClient.PostAsync<Library>("/api/libraries", request);
        }

        /// <summary>
        /// This endpoint retrieves all libraries accessible to the user.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<Library[]>> GetAllLibraries()
        {
            return await _httpClient.GetAsync<Library[]>("/api/libraries");
        }

        /// <summary>
        /// This endpoint retrieves a library.
        /// </summary>
        /// <param name="id">The ID of the library to retrieve.</param>
        /// <returns></returns>
        public async Task<Response<Library>> GetLibrary(string id)
        {
            return await _httpClient.GetAsync<Library>($"/api/libraries/{id}");
        }

        /// <summary>
        /// This endpoint retrieves a library, including filter data.
        /// </summary>
        /// <param name="id">The ID of the library to retrieve.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryIncludingFilterDataResponse>> GetLibraryIncludingFilterData(string id)
        {
            return await _httpClient.GetAsync<GetLibraryIncludingFilterDataResponse>($"/api/libraries/{id}?include=filterdata");
        }

        /// <summary>
        /// This endpoint updates a library.
        ///
        /// When updating folders you must pass in the full array of folders. Any missing folders from the array will be removed. New folders must not have an id set because this will be set automatically.
        /// </summary>
        /// <param name="id">The ID of the library to update.</param>
        /// <param name="request">The updated options and settings for the library.</param>
        /// <returns></returns>
        public async Task<Response<Library>> UpdateLibrary(string id, UpdateLibraryRequest request)
        {
            return await _httpClient.PatchAsync<Library>($"/api/libraries/{id}", request);
        }

        /// <summary>
        /// This endpoint deletes a library.
        /// </summary>
        /// <param name="id">The ID of the library to delete.</param>
        /// <returns></returns>
        public async Task<Response<Library>> DeleteLibrary(string id)
        {
            return await _httpClient.DeleteAsync<Library>($"/api/libraries/{id}");
        }

        #region Libraries_GetLibraryItems
        /// <summary>
        /// This endpoint returns a library's items, optionally sorted and/or filtered.
        ///
        /// This is an endpoint that gives all the options and let you choose pretty much what type of response you want. This is because there are so many different options available as what is sent in.
        /// The most used responses have their own endpoints that can be used if you don't want to find every type that can be returned for every settings.
        /// </summary>
        /// <typeparam name="TLibraryItemType">The type of library item returned. The most common is if it is LibraryItem for Book or LibraryItem for Podcast or one of it's minified versions. But some combinations of settings may also send other or different attributes as well.</typeparam>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <param name="minified">Whether to request minified objects.</param>
        /// <param name="collapseseries">Whether to collapse books in a series to a single entry.</param>
        /// <param name="include">A comma separated list of what to include with the library items. The only current option is rssfeed.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemResponse<TLibraryItemType>>> GetLibraryItems<TLibraryItemType>(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null, bool minified = false, bool collapseseries = false, string include = null)
        {
            var query = string.Empty;
            if (sortBy != null)
            {
                query += $"&sort={sortBy}";
            }
            if (filter != null)
            {
                query += $"&filter={filter.ToFilterText()}";
            }
            if (include != null)
            {
                query += $"&include={include}";
            }
            return await _httpClient.GetAsync<GetLibraryItemResponse<TLibraryItemType>>($"/api/libraries/{id}?limit={limit}&page={page}&desc={sortByDesc}&minified={minified.ToInt()}&collapseseries={collapseseries.ToInt()}{query}");
        }

        /// <summary>
        /// This endpoint returns a library's items, optionally sorted and/or filtered. This assumes the library is a library of books.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemResponse<BookLibraryItem>>> GetBookLibraryItems(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibraryItems<BookLibraryItem>(id, limit, page, sortBy, sortByDesc, filter, false, false, null);
        }

        /// <summary>
        /// This endpoint returns a library's items, optionally sorted and/or filtered. This assumes the library is a library of books.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemResponse<BookLibraryItemMinified>>> GetBookLibraryItemsMinified(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibraryItems<BookLibraryItemMinified>(id, limit, page, sortBy, sortByDesc, filter, true, false, null);
        }

        /// <summary>
        /// This endpoint returns a library's items, optionally sorted and/or filtered. This assumes the library is a library of podcasts.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemResponse<PodcastLibraryItem>>> GetPodcastLibraryItems(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibraryItems<PodcastLibraryItem>(id, limit, page, sortBy, sortByDesc, filter, false, false, null);
        }

        /// <summary>
        /// This endpoint returns a library's items, optionally sorted and/or filtered. This assumes the library is a library of podcasts.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemResponse<PodcastLibraryItemMinified>>> GetPodcastLibraryItemsMinified(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibraryItems<PodcastLibraryItemMinified>(id, limit, page, sortBy, sortByDesc, filter, true, false, null);
        }
        #endregion

        /// <summary>
        /// This endpoint removes a library's items that have issues.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <returns></returns>
        public async Task<Response<string>> RemoveLibraryItemsWithIssues(string id)
        {
            return await _httpClient.DeleteAsync<string>($"/api/libraries/{id}/issues");
        }

        /// <summary>
        /// This endpoint retrieves the podcast episodes downloads of the library.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <returns></returns>
        public async Task<Response<GetPodcastLibraryEpisodeDownloadResponse>> GetPodcastLibraryEpisodeDownload(string id)
        {
            return await _httpClient.GetAsync<GetPodcastLibraryEpisodeDownloadResponse>($"/api/libraries/{id}/episode-downloads");
        }
        #endregion
    }
}

