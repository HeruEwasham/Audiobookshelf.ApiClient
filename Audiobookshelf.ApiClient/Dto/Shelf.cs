using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Audiobookshelf.ApiClient.Dto
{
    // TODO: Not all possible returned values is gotten. See documentation here: https://api.audiobookshelf.org/#get-a-library-39-s-personalized-view
    public class Shelf
	{
        /// <summary>
        /// The ID of the shelf.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The label of the shelf.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; private set; }

        /// <summary>
        /// The label string key of the shelf, for internationalization purposes.
        /// </summary>
        [JsonProperty("labelStringKey")]
        public string LabelStringKey { get; private set; }

        /// <summary>
        /// The type of items the shelf represents. Can be book, series, authors, episode, or podcast.
        /// </summary>
        [JsonProperty("type")]
        public ShelfType Type { get; private set; }

        /// <summary>
        /// The category of the shelf.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; private set; }

        /// <summary>
        /// The entities to be displayed on the shelf.
        /// </summary>
        [JsonProperty("entities")]
        private JArray _entities;

        /// <summary>
        /// If Type is Book, returns the results, if not, returns null.
        /// </summary>
        /// <returns></returns>
        public BookLibraryItemMinified[] GetBookEntities()
        {
            if (Type == ShelfType.Book)
            {
                return _entities.ToObject<BookLibraryItemMinified[]>();
            }
            return null;
        }

        /// <summary>
        /// If Type is Podcast or Episode, returns the results, if not, returns null.
        /// </summary>
        /// <returns></returns>
        public PodcastLibraryItemMinified[] GetPodcastEntities()
        {
            if (Type == ShelfType.Podcast || Type == ShelfType.Episode)
            {
                return _entities.ToObject<PodcastLibraryItemMinified[]>();
            }
            return null;
        }

        /// <summary>
        /// If Type is Series, returns the results, if not, returns null.
        /// </summary>
        /// <returns></returns>
        public SeriesWithShelfExtra[] GetSeriesEntities()
        {
            if (Type == ShelfType.Series)
            {
                return _entities.ToObject<SeriesWithShelfExtra[]>();
            }
            return null;
        }

        /// <summary>
        /// If Type is Authors, returns the results, if not, returns null.
        /// </summary>
        /// <returns></returns>
        public AuthorExpanded[] GetAuthorsEntities()
        {
            if (Type == ShelfType.Authors)
            {
                return _entities.ToObject<AuthorExpanded[]>();
            }
            return null;
        }
    }
}

