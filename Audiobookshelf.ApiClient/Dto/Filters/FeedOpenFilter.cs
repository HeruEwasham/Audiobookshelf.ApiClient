using System;
namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after items with their RSS-feeds open.
    /// </summary>
	public class FeedOpenFilter : IFilter
	{
        public string ToFilterText()
        {
            return "feed-open";
        }
    }
}

