using ERAAPI.Attributes;
using ERAAPI.DTO;
using ERAAPI.DTO.Product;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;

namespace ERAAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }





        [HttpGet("ById")]
        public async Task<ActionResult<GeneralResponse<Product>>> GetProductById(
         decimal productId = 0, string productCode = "", string barcode = "")
        {
            var product = await _repo.GetProductByIdAsync(productId, productCode, barcode);

            if (product != null)
            {
                return new GeneralResponse<Product>
                {
                    Success = true,
                    Data = product,
                    Message = "Product fetched successfully"
                };
            }
            else
            {
                return new GeneralResponse<Product>
                {
                    Success = false,
                    Data = null,
                    Message = "Product not found"
                };
            }
        }





        [HttpGet("GetAllProducts")]
        [AuthorizePrivilege("Product", "ViewAll")]
        public async Task<ActionResult<GeneralResponse<IEnumerable<ProductInfoDTO>>>> GetAllProducts()
        {
            var products = await _repo.ProductViewAllAsync();

            return new GeneralResponse<IEnumerable<ProductInfoDTO>>
            {
                Success = true,
                Data = products,
                Message = "Fetched successfully"
            };
        }



        [HttpPost("SaveProduct")]
        [AuthorizePrivilege("Product", "Update")]
        public async Task<ActionResult<GeneralResponse<decimal>>> SaveProduct([FromBody] ProductCreateDTO product)
        {
            var productId = await _repo.SaveOrUpdateProductAsync(product);
            string message = product.ProductId ==0 ? "Saved successfully" : "Update successfully";
            
            return new GeneralResponse<decimal>
            {
                Success = true,
                Data = productId,
                Message = message
            };
        }



        [HttpGet("ByGroup/{groupId}")]
        [AuthorizePrivilege("Product", "View")]
        public async Task<ActionResult<GeneralResponse<List<Product>>>> GetProductsByGroup(decimal groupId)
        {
            var products = await _repo.GetProductsByGroupIdAsync(groupId);
            return new GeneralResponse<List<Product>>
            {
                Success = true,
                Data = products,
                Message = "Products fetched successfully"
            };
        }



        [HttpDelete("CheckReferences/{productId}")]
        [AuthorizePrivilege("Product", "Delete")]
        public ActionResult<GeneralResponse<bool>> CheckAndDeleteProduct(decimal productId)
        {
            var deleted = _repo.TryDeleteProduct(productId);

            if (deleted)
            {
                return new GeneralResponse<bool>
                {
                    Success = true,
                    Data = true,
                    Message = "Product deleted successfully"
                };
            }
            else
            {
                return new GeneralResponse<bool>
                {
                    Success = false,
                    Data = false,
                    Message = "Product is referenced elsewhere or Not exist and cannot be deleted"
                };
            }
        }



    }
}
