using Core.Persistence.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface ISomeFeatureEntityRepository : IAsyncRepository<SomeFeatureEntity>, IRepository<SomeFeatureEntity>
    {

    }
}