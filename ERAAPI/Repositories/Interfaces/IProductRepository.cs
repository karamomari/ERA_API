using ERAAPI.DTO.Product;
using ERAAPI.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ERAAPI.Repositories.Interfaces
{
    public interface IProductRepository
    {

        Task<Product?> GetProductByIdAsync(decimal productId, string productCode, string barcode);
        Task<IEnumerable<ProductInfoDTO>> ProductViewAllAsync();

        Task<decimal> SaveOrUpdateProductAsync(ProductCreateDTO info);

        Task<bool> IsBarcodeExistAsync(string barcode, decimal productId);

         Task<List<Product>> GetProductsByGroupIdAsync(decimal groupId);


        bool TryDeleteProduct(decimal productId);

    }
}
