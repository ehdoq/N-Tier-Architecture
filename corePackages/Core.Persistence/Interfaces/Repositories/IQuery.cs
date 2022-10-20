namespace Core.Persistence.Interfaces.Repositories
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}