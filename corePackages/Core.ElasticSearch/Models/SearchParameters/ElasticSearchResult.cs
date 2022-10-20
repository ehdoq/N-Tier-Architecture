using Core.ElasticSearch.Interfaces;

namespace Core.ElasticSearch.Models.SearchParameters
{
    public class ElasticSearchResult : IElasticSearchResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }

        public ElasticSearchResult(bool success, string message) : this(success)
        {
            Message = message;
        }

        public ElasticSearchResult(bool success)
        {
            Success = success;
        }
    }
}