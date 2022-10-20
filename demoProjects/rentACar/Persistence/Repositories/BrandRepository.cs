using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepository<Brand, AppDbContext>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {

        }
    }
}