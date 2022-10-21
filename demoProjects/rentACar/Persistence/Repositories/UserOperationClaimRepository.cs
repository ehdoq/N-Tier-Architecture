using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class UserOperationClaimRepository : EfRepository<UserOperationClaim, AppDbContext>, IUserOperationClaimRepository
    {
        public UserOperationClaimRepository(AppDbContext context) : base(context)
        {

        }
    }
}