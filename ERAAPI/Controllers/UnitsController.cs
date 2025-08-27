using AutoMapper;
using ERAAPI.DTO;
using ERAAPI.DTO.UnitDTO;
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
    public class UnitsController : ControllerBase
    {
        private readonly IUnitRepository _repo;
        private readonly IMapper _mapper;

        public UnitsController(IUnitRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet("all")]
        public async Task<ActionResult<GeneralResponse<IEnumerable<UnitListDTO>>>> GetAllUnits()
        {
            var units = await _repo.GetAllUnits();
            return new GeneralResponse<IEnumerable<UnitListDTO>>
            {
                Success = true,
                Data = units,
                Message = "Units fetched successfully"
            };
        }


        [HttpGet("UnitsProduct")]
        public async Task<ActionResult<GeneralResponse<IEnumerable<UnitByProductDTO>>>> GetUnitsByProduct()
        {
            var units = await _repo.GetUnitsByProduct();
            return new GeneralResponse<IEnumerable<UnitByProductDTO>>
            {
                Success = true,
                Data = units,
                Message = "Units fetched successfully"
            };
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralResponse<Unit>>> GetUnitById(decimal id)
        {
            var unit = await _repo.GetUnitByIdAsync(id);
            if (unit == null)
            {
                return new GeneralResponse<Unit>
                {
                    Success = false,
                    Data = null,
                    Message = "Unit not found"
                };
            }

            return new GeneralResponse<Unit>
            {
                Success = true,
                Data = unit,
                Message = "Unit fetched successfully"
            };
        }




        [HttpPost("saveOrUpdate")]
        public async Task<ActionResult<GeneralResponse<decimal>>> SaveOrUpdateUnit([FromBody] Unit unit)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            var currentUserId = (userIdClaim != null && decimal.TryParse(userIdClaim.Value, out var parsedId))
                ? parsedId
                : 0;
            unit.ModifiedBy = currentUserId;
            unit.CreatedBy = currentUserId;

            var unitId = await _repo.SaveOrUpdateUnitAsync(unit);

            return new GeneralResponse<decimal>
            {
                Success = true,
                Data = unitId,
                Message = unit.UnitId == 0 ? "Unit created successfully" : "Unit updated successfully"
            };
        }



        [HttpDelete("checkReferences/{id}")]
        public async Task<ActionResult<GeneralResponse<decimal>>> CheckReferencesAndDelete(decimal id)
        {
            var result = await _repo.UnitCheckReferencesDeleteAsync(id);

            if (result == 0)
            {
                return new GeneralResponse<decimal>
                {
                    Success = false,
                    Data = id,
                    Message = "Cannot delete: Unit is referenced in Products or Stock Posting"
                };
            }

            return new GeneralResponse<decimal>
            {
                Success = true,
                Data = id,
                Message = "Unit deleted successfully"
            };
        }


        [HttpPost("saveOrUpdateToTest")]
        public async Task<ActionResult<GeneralResponse<decimal>>> SaveOrUpdateUnitToTeste([FromBody] UnitCreateOrUpdateDTO dto)
        {

            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            var currentUserId = (userIdClaim != null && decimal.TryParse(userIdClaim.Value, out var parsedId))
                ? parsedId
                : 0;

            var unit = _mapper.Map<Unit>(dto);

                unit.CreatedBy = currentUserId;
                unit.ModifiedBy = currentUserId;
                unit.Extra1 = "";
                unit.Extra2 = "";
                unit.CreatedDate = DateTime.Now;
         

            decimal savedId = await _repo.SaveOrUpdateUnitAsync(unit);

            return new GeneralResponse<decimal>
            {
                Success = true,
                Data = savedId,
                Message = "Unit saved successfully"
            };
        }


    }



}
