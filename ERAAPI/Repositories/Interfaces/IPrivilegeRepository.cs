using ERAAPI.Models;

namespace ERAAPI.Repositories.Interfaces
{
    public interface IPrivilegeRepository
    {
        Task<List<Privilege>> PrivilegeViewAllAsync();
    }
}
