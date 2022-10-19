using Core.Security.Entities;
using Core.Security.JWT;

namespace Core.Security.Interfaces.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, IList<OperationClaim> operationClaims);
        RefreshToken CreateRefreshToken(User user, string ipAddress);
    }
}