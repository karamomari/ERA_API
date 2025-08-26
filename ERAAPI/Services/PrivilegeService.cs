using ERAAPI.Models;
using ERAAPI.Repositories.Implementations;
using ERAAPI.Repositories.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace ERAAPI.Services
{
    public class PrivilegeService
    {
        private readonly IMemoryCache _cache;
        private readonly IPrivilegeRepository _repo;
        private const string CacheKey = "Privileges";

        public PrivilegeService(IMemoryCache cache, IPrivilegeRepository repo)
        {
            _cache = cache;
            _repo = repo;
        }

        public async Task<List<Privilege>> GetAllPrivilegesAsync()
        {
            if (!_cache.TryGetValue(CacheKey, out List<Privilege> privileges))
            {
                privileges = await _repo.PrivilegeViewAllAsync();

                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1),
                    SlidingExpiration = TimeSpan.FromMinutes(10)
                };

                _cache.Set(CacheKey, privileges, cacheOptions);
            }

            return privileges;
        }

        public async Task<List<Privilege>> GetPrivilegesByRoleAsync(decimal roleId)
        {
            var privileges = await GetAllPrivilegesAsync();
            return privileges.Where(p => p.RoleId == roleId).ToList();
        }
    }
}
