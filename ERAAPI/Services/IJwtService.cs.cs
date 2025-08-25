using ERAAPI.Data;
using ERAAPI.Repositories.Interfaces;

namespace ERAAPI.Services
{
    public interface IJwtService
    {
        string GenerateToken(string username, decimal userId);
    }
}
