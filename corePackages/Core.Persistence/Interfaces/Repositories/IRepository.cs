using Core.Persistence.Interfaces.Paging;
using Core.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Persistence.Interfaces.Repositories
{
    public interface IRepository<T> : IQuery<T> where T : Entity
    {
        IPaginate<T> GetList(Expression<Func<T, bool>>? predicate = null,
                             Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                             Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                             int index = 0, int size = 10, bool enableTracking = true);
        T Get(Expression<Func<T, bool>> predicate);
        IPaginate<T> GetListByDynamic(Dynamic.Dynamic dynamic,
                                      Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                      int index = 0, int size = 10, bool enableTracking = true);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}