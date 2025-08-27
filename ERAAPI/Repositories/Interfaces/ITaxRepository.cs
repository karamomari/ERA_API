using ERAAPI.Models;

namespace ERAAPI.Repositories.Interfaces
{
    public interface ITaxRepository
    {
        Task<bool> TaxNameExistsAsync(string taxName, decimal taxId);
        Task<decimal> SaveOrUpdateTaxAsync(Tax tax);

        Task<List<Tax>> GetAllProductTaxesAsync();
        Task<List<Tax>> GetAllTaxesAsync();
        Task<Tax?> TaxViewById(decimal id);
        Task<int> TaxCheckReferencesDelete(decimal id);
    }
}
