using Core.ElasticSearch.Models;
using Core.ElasticSearch.Models.ElasticSearchModel;
using Core.ElasticSearch.Models.SearchParameters;
using Nest;

namespace Core.ElasticSearch.Interfaces
{
    public interface IElasticSearchManager
    {
        IReadOnlyDictionary<IndexName, IndexState> GetIndexList();
        Task<List<ElasticSearchGetModel<T>>> GetAllSearch<T>(SearchParameters parameters) where T : class;
        Task<List<ElasticSearchGetModel<T>>> GetSearchByField<T>(SearchByFieldParameters fieldParameters) where T : class;
        Task<List<ElasticSearchGetModel<T>>> GetSearchBySimpleQueryString<T>(SearchByQueryParameters queryParameters) where T : class;
        Task<IElasticSearchResult> InsertAsync(ElasticSearchInsertUpdateModel model);
        Task<IElasticSearchResult> InsertManyAsync(string indexName, object[] items);
        Task<IElasticSearchResult> CreateNewIndexAsync(IndexModel indexModel);
        Task<IElasticSearchResult> UpdateByElasticIdAsync(ElasticSearchInsertUpdateModel model);
        Task<IElasticSearchResult> DeleteByElasticIdAsync(ElasticSearchModel model);
    }
}