using ERAAPI.Models;

namespace ERAAPI.Repositories.Interfaces
{
    public interface ITaxRepository
    {
        Task<bool> TaxNameExistsAsync(string taxName, decimal taxId);
        Task<decimal> SaveOrUpdateTaxAsync(Tax tax);

        Task<List<Tax>> GetAllProductTaxesAsync();
    }
}
