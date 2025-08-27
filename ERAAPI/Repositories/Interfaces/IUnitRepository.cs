using ERAAPI.DTO.UnitDTO;
using ERAAPI.Models;

namespace ERAAPI.Repositories.Interfaces
{
    public interface IUnitRepository
    {
        Task<IEnumerable<UnitListDTO>> GetAllUnits();
        Task<IEnumerable<UnitByProductDTO>> GetUnitsByProduct();
        Task<Unit> GetUnitByIdAsync(decimal id);

        Task<decimal> SaveOrUpdateUnitAsync(Unit unit);

        Task<decimal> UnitCheckReferencesDeleteAsync(decimal id);
    }
}
