using ERAAPI.Data;
using ERAAPI.DTO;

namespace ERAAPI.Repositories.Interfaces
{
    public interface IAuthRepository
    {

        TblUser? GetUserByUserNameAndPassword(string username, string password);

    }
}
