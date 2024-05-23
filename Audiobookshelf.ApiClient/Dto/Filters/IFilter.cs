namespace Audiobookshelf.ApiClient.Dto.Filters
{
    public interface IFilter
	{
		/// <summary>
		/// Generates the filter text including encoding.
		/// </summary>
		/// <returns></returns>
		string ToFilterText();
	}
}

