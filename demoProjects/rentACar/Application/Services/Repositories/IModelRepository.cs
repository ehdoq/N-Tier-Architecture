using Core.Persistence.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IModelRepository : IAsyncRepository<Model>, IRepository<Model>
    {

    }
}