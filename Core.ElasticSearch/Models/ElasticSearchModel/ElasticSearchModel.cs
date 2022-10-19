using Nest;

namespace Core.ElasticSearch.Models.ElasticSearchModel
{
    public class ElasticSearchModel
    {
        public Id? ElasticId { get; set; }
        public string? IndexName { get; set; }
    }
}