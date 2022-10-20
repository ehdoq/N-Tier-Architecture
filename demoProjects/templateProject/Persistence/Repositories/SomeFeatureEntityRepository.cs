using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class SomeFeatureEntityRepository : EfRepository<SomeFeatureEntity, AppDbContext>, ISomeFeatureEntityRepository
    {
        public SomeFeatureEntityRepository(AppDbContext context) : base(context)
        {

        }
    }
}