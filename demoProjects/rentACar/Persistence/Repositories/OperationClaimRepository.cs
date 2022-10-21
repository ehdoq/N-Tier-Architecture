using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class OperationClaimRepository : EfRepository<OperationClaim, AppDbContext>, IOperationClaimRepository
    {
        public OperationClaimRepository(AppDbContext context) : base(context)
        {

        }
    }
}