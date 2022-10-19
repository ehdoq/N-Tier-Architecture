namespace Core.ElasticSearch.Interfaces
{
    public interface IElasticSearchResult
    {
        bool Success { get; }
        string Message { get; }
    }
}