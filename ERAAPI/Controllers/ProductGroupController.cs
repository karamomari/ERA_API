using ERAAPI.DTO;
using ERAAPI.DTO.ProductGroupDTO;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ERAAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGroupController : ControllerBase
    {
        private readonly IProductGroupRepository _repo;

        public ProductGroupController(IProductGroupRepository repo)
        {
            _repo = repo;
        }



        [HttpGet("all")]
        public async Task<ActionResult<GeneralResponse<IEnumerable<ProductGroup>>>> GetAll()
        {
            var list = await _repo.GetAllPOSAsync();

            return new GeneralResponse<IEnumerable<ProductGroup>>
            {
                Success = true,
                Data = list,
                Message = "Fetched successfully"
            };
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralResponse<ProductGroup>>> GetById(decimal id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null)
            {
                return new GeneralResponse<ProductGroup>
                {
                    Success = false,
                    Data = null!,
                    Message = "Product group not found"
                };
            }

            return new GeneralResponse<ProductGroup>
            {
                Success = true,
                Data = entity,
                Message = "Fetched successfully"
            };
        }


        [HttpPost("saveandupdate")]
        public async Task<ActionResult<GeneralResponse<decimal>>> SaveAndUpdate(ProductGroupCreateDTO dto)
        {

            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            var currentUserId = (userIdClaim != null && decimal.TryParse(userIdClaim.Value, out var parsedId))
                ? parsedId
                : 0;


            var exists = await _repo.CheckNameExistenceAsync(dto.GroupName, dto.GroupId);
            if (exists)
            {
                return new GeneralResponse<decimal>
                {
                    Success = false,
                    Data = 0,
                    Message = "Product group already exists"
                };
            }

            var entity = new ProductGroup
            {
                GroupId = dto.GroupId,
                GroupName = dto.GroupName,
                GroupUnder = dto.GroupUnder,
                Narration = dto.Narration,
                Extra1 = "",
                Extra2 = "",
                ExtraDate = DateTime.Now,
                CreatedBy = currentUserId,
                CreatedDate = DateTime.Now,
                ModifiedBy = currentUserId,
                ModifiedDate = DateTime.Now
            };

            var id = await _repo.SaveAndUpdateAsync(entity);

            var success = id > 0;
            var message = !success
                ? "Operation failed"
                : (dto.GroupId == 0 ? "Saved successfully" : "Updated successfully");

            return new GeneralResponse<decimal>
            {
                Success = success,
                Data = id,
                Message = message
            };
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<GeneralResponse<bool>>> Delete(decimal id)
        {
            if (id == 0)
            {
                return new GeneralResponse<bool>
                {
                    Success = false,
                    Data = false,
                    Message = "Invalid id"
                };
            }

            var affected = await _repo.CheckReferencesDeleteAsync(id);

            if (affected == 0)
            {
                return new GeneralResponse<bool>
                {
                    Success = false,
                    Data = false,
                    Message = "Cannot delete: references exist or id not found"
                };
            }

            return new GeneralResponse<bool>
            {
                Success = true,
                Data = true,
                Message = "Deleted successfully"
            };
        }






    }
}
