using System;
namespace Audiobookshelf.ApiClient.Dto.Filters
{
    /// <summary>
    /// Filter after items with issues.
    /// </summary>
	public class IssueFilter : IFilter
	{
        public string ToFilterText()
        {
            return "issues";
        }
    }
}

