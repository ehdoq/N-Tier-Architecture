using Core.Persistence.Interfaces.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories
{
    public interface IOperationClaimRepository : IAsyncRepository<OperationClaim>, IRepository<OperationClaim>
    {

    }
}