using Core.Persistence.Interfaces.Repositories;
using Entities.Entities;

namespace Application.Services.Repositories
{
    public interface ISomeFeatureEntityRepository : IAsyncRepository<SomeFeatureEntity>, IRepository<SomeFeatureEntity>
    {

    }
}