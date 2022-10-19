namespace Core.ElasticSearch.Models.ElasticSearchModel
{
    public class ElasticSearchGetModel<T>
    {
        public string? ElasticId { get; set; }
        public T? Item { get; set; }
    }
}