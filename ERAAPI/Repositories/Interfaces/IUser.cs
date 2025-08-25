using ERAAPI.Data;
using ERAAPI.Models;

namespace ERAAPI.Repositories.Interfaces
{
    public interface IUser
    {
       
        decimal UserSaveAndUpdate(UserInfo info);
    }
}
