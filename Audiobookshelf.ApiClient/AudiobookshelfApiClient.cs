using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
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
        public async Task<Response<GetLibraryItemsResponse<TLibraryItemType>>> GetLibraryItems<TLibraryItemType>(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null, bool minified = false, bool collapseseries = false, string include = null)
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
            return await _httpClient.GetAsync<GetLibraryItemsResponse<TLibraryItemType>>($"/api/libraries/{id}/items?limit={limit}&page={page}&desc={sortByDesc}&minified={minified.ToInt()}&collapseseries={collapseseries.ToInt()}{query}");
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
        public async Task<Response<GetLibraryItemsResponse<BookLibraryItem>>> GetBookLibraryItems(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
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
        public async Task<Response<GetLibraryItemsResponse<BookLibraryItemMinified>>> GetBookLibraryItemsMinified(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
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
        public async Task<Response<GetLibraryItemsResponse<PodcastLibraryItem>>> GetPodcastLibraryItems(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
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
        public async Task<Response<GetLibraryItemsResponse<PodcastLibraryItemMinified>>> GetPodcastLibraryItemsMinified(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
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

        #region Libraries_GetLibrarySeries
        /// <summary>
        /// This endpoint returns a library's series. Optionally sorted and/or filtered.
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
        /// <param name="include">A comma separated list of what to include with the library items. The only current option is rssfeed.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemsResponse<SeriesBooks<TLibraryItemType>>>> GetLibrarySeries<TLibraryItemType>(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null, bool minified = false, string include = null)
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
            return await _httpClient.GetAsync<GetLibraryItemsResponse<SeriesBooks<TLibraryItemType>>>($"/api/libraries/{id}/series?limit={limit}&page={page}&desc={sortByDesc}&minified={minified.ToInt()}{query}");
        }

        /// <summary>
        /// This endpoint returns a library's series. Optionally sorted and/or filtered.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemsResponse<SeriesBooks<BookLibraryItem>>>> GetBookLibrarySeries(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibrarySeries<BookLibraryItem>(id, limit, page, sortBy, sortByDesc, filter, false, null);
        }

        /// <summary>
        /// This endpoint returns a library's series. Optionally sorted and/or filtered.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemsResponse<SeriesBooks<BookLibraryItemMinified>>>> GetBookLibrarySeriesMinified(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibrarySeries<BookLibraryItemMinified>(id, limit, page, sortBy, sortByDesc, filter, true, null);
        }
        #endregion

        #region Libraries_GetLibraryCollections
        /// <summary>
        /// This endpoint returns a library's collections. Optionally sorted and/or filtered.
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
        /// <param name="include">A comma separated list of what to include with the library items. The only current option is rssfeed.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemsResponse<TLibraryItemType>>> GetLibraryCollections<TLibraryItemType>(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null, bool minified = false, string include = null)
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
            return await _httpClient.GetAsync<GetLibraryItemsResponse<TLibraryItemType>>($"/api/libraries/{id}/collections?limit={limit}&page={page}&desc={sortByDesc}&minified={minified.ToInt()}{query}");
        }

        /// <summary>
        /// This endpoint returns a library's collections. Optionally sorted and/or filtered.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemsResponse<BookCollection>>> GetBookLibraryCollections(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibraryCollections<BookCollection>(id, limit, page, sortBy, sortByDesc, filter, false, null);
        }

        /// <summary>
        /// This endpoint returns a library's collections. Optionally sorted and/or filtered.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <param name="sortBy">What to sort the results by. Specify the attribute to sort by using JavaScript object notation. For example, to sort by title use sort=media.metadata.title. When filtering for a series, sort can also be sequence.</param>
        /// <param name="sortByDesc">Whether to reverse the sort order.</param>
        /// <param name="filter">What to filter the results by.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryItemsResponse<BookCollectionMinified>>> GetBookLibraryCollectionsMinified(string id, int limit = 0, int page = 0, string sortBy = null, bool sortByDesc = false, IFilter filter = null)
        {
            return await GetLibraryCollections<BookCollectionMinified>(id, limit, page, sortBy, sortByDesc, filter, true, null);
        }
        #endregion

        #region Libraries_GetLibraryPlaylists
        /// <summary>
        /// This endpoint returns a library's playlists for the authenticated user.
        /// </summary>
        /// <typeparam name="TLibraryItemType">The returned type. This depends if it is a library of books or podcasts. See GetBookLibraryUserPlaylists and GetPodcastLibraryUserPlaylists.</typeparam>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <returns></returns>
        private async Task<Response<GetLibraryUserPlaylistsResponse<TLibraryItemType>>> GetLibraryUserPlaylists<TLibraryItemType>(string id, int limit = 0, int page = 0)
        {
            return await _httpClient.GetAsync<GetLibraryUserPlaylistsResponse<TLibraryItemType>>($"/api/libraries/{id}/playlists?limit={limit}&page={page}");
        }

        /// <summary>
        /// This endpoint returns a library's playlists for the authenticated user. This assumes it is a library of books.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryUserPlaylistsResponse<BookLibraryItemExpanded>>> GetBookLibraryUserPlaylists(string id, int limit = 0, int page = 0)
        {
            return await GetLibraryUserPlaylists<BookLibraryItemExpanded>(id, limit, page);
        }

        /// <summary>
        /// This endpoint returns a library's playlists for the authenticated user. This assumes it is a library of podcasts.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryUserPlaylistsResponse<PodcastLibraryItemMinified>>> GetPodcastLibraryUserPlaylists(string id, int limit = 0, int page = 0)
        {
            return await GetLibraryUserPlaylists<PodcastLibraryItemMinified>(id, limit, page);
        }
        #endregion

        /// <summary>
        /// This endpoint returns a library's personalized view for home page display.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of items in each 'shelf' of the response. Default value is 10.</param>
        /// <returns></returns>
        public async Task<Response<Shelf[]>> GetLibraryPersonalizedView(string id, int limit = 10)
        {
            return await _httpClient.GetAsync<Shelf[]>($"/api/libraries/{id}/personalized?limit={limit}");
        }

        /// <summary>
        /// This endpoint returns a library's filter data that can be used for displaying a filter list.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <returns></returns>
        public async Task<Response<LibraryFilterData>> GetLibraryFilterData(string id)
        {
            return await _httpClient.GetAsync<LibraryFilterData>($"/api/libraries/{id}/filterdata");
        }

        /// <summary>
        /// This endpoint searches a library for the query and returns the results.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="query">The search query.</param>
        /// <param name="limit">Limit the number of returned results.</param>
        /// <returns></returns>
        public async Task<Response<SearchLibraryResponse>> SearchLibrary(string id, string query, int limit = 12)
        {
            return await _httpClient.GetAsync<SearchLibraryResponse>($"/api/libraries/{id}/search?q={HttpUtility.UrlEncode(query)}&limit={limit}");
        }

        /// <summary>
        /// This endpoint returns a library's stats.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryStatsResponse>> GetLibraryStats(string id)
        {
            return await _httpClient.GetAsync<GetLibraryStatsResponse>($"/api/libraries/{id}/stats");
        }

        /// <summary>
        /// This endpoint returns a library's authors.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryAuthorsResponse>> GetLibraryAuthors(string id)
        {
            return await _httpClient.GetAsync<GetLibraryAuthorsResponse>($"/api/libraries/{id}/authors");
        }

        /// <summary>
        /// This endpoint matches all items in a library using quick match. Quick match populates empty book details and the cover with the first book result from the library's default metadata provider. Does not overwrite details unless the "Prefer matched metadata" server setting is enabled.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <returns></returns>
        public async Task<Response<string>> MatchAllLibraryItems(string id)
        {
            return await _httpClient.GetAsync<string>($"/api/libraries/{id}/matchall");
        }

        /// <summary>
        /// This endpoint starts a scan of a library's folders for new library items and changes to existing library items.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="force">Whether to force a rescan for all of a library's items.</param>
        /// <returns></returns>
        public async Task<Response<string>> ScanLibraryFolders(string id, bool force)
        {
            return await _httpClient.PostAsync<string>($"/api/libraries/{id}/scan?force={force.ToInt()}", null);
        }

        /// <summary>
        /// This endpoint returns a library's newest unfinished podcast episodes, sorted by episode publish time.
        /// </summary>
        /// <param name="id">The ID of the library.</param>
        /// <param name="limit">Limit the number of returned results per page. If 0, no limit will be applied.</param>
        /// <param name="page">The page number (0 indexed) to request. If there is no limit applied, then page will have no effect and all results will be returned.</param>
        /// <returns></returns>
        public async Task<Response<GetLibraryRecentEpisodesResponse>> GetLibraryRecentEpisodes(string id, int limit = 0, int page = 0)
        {
            return await _httpClient.GetAsync<GetLibraryRecentEpisodesResponse>($"/api/libraries/{id}/recent-episodes?limit={limit}&page={page}");
        }

        /// <summary>
        /// This endpoint will change the displayOrder of the libraries specified. It will return an array of all libraries.
        /// </summary>
        /// <param name="request">Array of library-representations to reorder.</param>
        /// <returns></returns>
        public async Task<Response<Library[]>> ReorderLibraryList(ReorderLibraryListRequest[] request)
        {
            return await _httpClient.PostAsync<Library[]>($"/api/libraries/order", request);
        }
        #endregion

        #region LibraryItems
        /// <summary>
        /// This endpoint will delete all library items from the database. No actual files will be deleted.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<string>> DeleteAllLibraryItems()
        {
            return await _httpClient.DeleteAsync<string>($"/api/items/all");
        }

        #region LibraryItems_GetLibraryItem
        /// <summary>
        /// This endpoint retrieves a library item.
        ///
        /// Expects the item to be a book-related item.
        /// </summary>
        /// <param name="id">The ID of the library item to retrieve.</param>
        /// <returns></returns>
        public async Task<Response<LibraryItem<Book>>> GetBookLibraryItem(string id)
        {
            return await _httpClient.GetAsync<LibraryItem<Book>>($"/api/items/{id}?expanded=0");
        }

        /// <summary>
        /// This endpoint retrieves a library item.
        ///
        /// Expects the item to be a podcast-related item.
        /// </summary>
        /// <param name="id">The ID of the library item to retrieve.</param>
        /// <returns></returns>
        public async Task<Response<LibraryItem<Podcast>>> GetPodcastLibraryItem(string id)
        {
            return await _httpClient.GetAsync<LibraryItem<Podcast>>($"/api/items/{id}?expanded=0");
        }

        /// <summary>
        /// This endpoint retrieves an expanded library item with all possible includes.
        ///
        /// Expects the item to be a book-related item.
        /// </summary>
        /// <param name="id">The ID of the library item to retrieve.</param>
        /// <returns></returns>
        public async Task<Response<GetBookLibraryItemExpanded>> GetBookLibraryItemExpanded(string id)
        {
            return await _httpClient.GetAsync<GetBookLibraryItemExpanded>($"/api/items/{id}?expanded=1&include=progress,rssfeed,authors");
        }

        /// <summary>
        /// This endpoint retrieves an expanded library item with all possible includes.
        ///
        /// Expects the item to be a podcast-related item.
        /// </summary>
        /// <param name="id">The ID of the library item to retrieve.</param>
        /// <returns></returns>
        public async Task<Response<GetPodcastLibraryItemExpanded>> GetPodcastLibraryItemExpanded(string id, string episodeId)
        {
            return await _httpClient.GetAsync<GetPodcastLibraryItemExpanded>($"/api/items/{id}?expanded=1&include=progress,rssfeed,downloads&episode={episodeId}");
        }
        #endregion

        /// <summary>
        /// This endpoint deletes a library item from the database. No files are deleted.
        /// </summary>
        /// <param name="id">The ID of the library item to delete.</param>
        /// <returns></returns>
        public async Task<Response<string>> DeleteLibraryItem(string id)
        {
            return await _httpClient.DeleteAsync<string>($"/api/items/{id}");
        }

        /// <summary>
        /// This endpoint updates a library item's media and returns the updated library item.
        /// </summary>
        /// <param name="id">The ID of the library item.</param>
        /// <param name="request">The request. Mark that this endpoint expect that all fields in the request that should not change is filled out. The request has helper methods to create a request based on some entities for this purpuse.</param>
        /// <returns></returns>
        public async Task<Response<UpdateLibraryItemMediaResponse<Book>>> UpdateLibraryItemMedia(string id, UpdateLibraryItemMediaBookRequest request)
        {
            return await _httpClient.PatchAsync<UpdateLibraryItemMediaResponse<Book>>($"/api/items/{id}/media", request);
        }

        /// <summary>
        /// This endpoint updates a library item's media and returns the updated library item.
        /// </summary>
        /// <param name="id">The ID of the library item.</param>
        /// <param name="request">The request. Mark that this endpoint expect that all fields in the request that should not change is filled out.</param>
        /// <returns></returns>
        public async Task<Response<UpdateLibraryItemMediaResponse<Podcast>>> UpdateLibraryItemMedia(string id, PodcastBase<PodcastMetadata> request)
        {
            return await _httpClient.PatchAsync<UpdateLibraryItemMediaResponse<Podcast>>($"/api/items/{id}/media", request);
        }

        /// <summary>
        /// This endpoint retrieves a library item's cover.
        /// </summary>
        /// <param name="id">The ID of the library item.</param>
        /// <param name="width">The requested width of the cover image.</param>
        /// <param name="height">The requested height of the cover image. If null the image is scaled proportionately.</param>
        /// <param name="format">The requested format of the cover image.</param>
        /// <returns></returns>
        public async Task<byte[]> GetLibraryItemCover(string id, int width = 400, int? height = null, ImageFormat format = ImageFormat.Jpeg)
        {
            var url = $"/api/items/{id}/cover?raw=0&width={width}&format={format}";
            if (height.HasValue)
            {
                url += $"&height={height.Value}";
            }
            return await _httpClient.GetByteArrayAsync(url);
        }

        /// <summary>
        /// This endpoint retrieves a library item's cover. Returns the raw cover image file instead of a scaled version
        /// </summary>
        /// <param name="id">The ID of the library item.</param>
        /// <returns></returns>
        public async Task<byte[]> GetLibraryItemCoverRaw(string id)
        {
            return await _httpClient.GetByteArrayAsync($"/api/items/{id}/cover?raw=1");
        }
        #endregion
    }
}

