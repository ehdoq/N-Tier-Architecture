namespace Core.ElasticSearch.Models.SearchParameters
{
    public class SearchByQueryParameters : SearchParameters
    {
        public string? QueryName { get; set; }
        public string? Query { get; set; }
        public string[]? Fields { get; set; }
    }
}