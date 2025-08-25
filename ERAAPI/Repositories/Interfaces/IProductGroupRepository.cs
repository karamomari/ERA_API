using ERAAPI.Models;

namespace ERAAPI.Repositories.Interfaces
{
    public interface IProductGroupRepository
    {
        Task<bool> CheckNameExistenceAsync(string name, decimal id);
        Task<decimal> SaveAndUpdateAsync(ProductGroup entity);

        Task<int> CheckReferencesDeleteAsync(decimal id);

        Task<ProductGroup?> GetByIdAsync(decimal id);

        Task<IEnumerable<ProductGroup>> GetAllPOSAsync();
    }
}
