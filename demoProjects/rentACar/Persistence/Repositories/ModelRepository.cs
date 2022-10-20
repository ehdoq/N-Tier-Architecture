using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class ModelRepository : EfRepository<Model, AppDbContext>, IModelRepository
    {
        public ModelRepository(AppDbContext context) : base(context)
        {

        }
    }
}