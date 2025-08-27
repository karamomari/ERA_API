using ERAAPI.DTO;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERAAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ITaxRepository _repo;

        public TaxController(ITaxRepository repo)
        {
            _repo = repo;
        }


        [HttpGet("ProductTaxes")]
        public async Task<ActionResult<GeneralResponse<List<Tax>>>> GetAllProductTaxes()
        {
            var taxes = await _repo.GetAllProductTaxesAsync();
            return new GeneralResponse<List<Tax>>
            {
                Success = true,
                Data = taxes,
                Message = "Product taxes fetched successfully"
            };
        }


        [HttpGet("Taxes")]
        public async Task<ActionResult<GeneralResponse<List<Tax>>>> GetAllTaxes()
        {
            var taxes = await _repo.GetAllTaxesAsync();
            return new GeneralResponse<List<Tax>>
            {
                Success = true,
                Data = taxes,
                Message = "Product taxes fetched successfully"
            };
        }


        [HttpGet("Taxe/{id}")]
        public async Task<ActionResult<GeneralResponse<Tax>>> GetTaxByID(decimal id)
        {
            var tax = await _repo.TaxViewById(id);

            if (tax == null)
            {
                return new GeneralResponse<Tax>
                {
                    Success = false,
                    Data = null,
                    Message = $"No Tax found with Id = {id}"
                };
            }

            return new GeneralResponse<Tax>
            {
                Success = true,
                Data = tax,
                Message = "Fetched successfully"
            };

        }

        [HttpPost("SaveOrUpdate")]
        public async Task<ActionResult<GeneralResponse<decimal>>> SaveOrUpdateTax(Tax tax)
        {
            if (await _repo.TaxNameExistsAsync(tax.TaxName, tax.TaxId))
            {
                return new GeneralResponse<decimal>
                {
                    Success = false,
                    Data = 0,
                    Message = "Tax name already exists."
                };
            }

            var taxId = await _repo.SaveOrUpdateTaxAsync(tax);
            string message = tax.TaxId == 0 ? "Tax saved successfully." : "Tax Updated successfully.";
            return new GeneralResponse<decimal>
            {
                Success = true,
                Data = taxId,
                Message = message
            };
        }

        [HttpDelete("CheckReferences/{id}")]
        public async Task<ActionResult<GeneralResponse<decimal>>> CheckReferencesAndDelete(decimal id)
        {
            var result = await _repo.TaxCheckReferencesDelete(id);

            if (result == 0)
            {
                return new GeneralResponse<decimal>
                {
                    Success = false,
                    Data = 0, 
                    Message = "Cannot delete: Tax is referenced in Products"
                };
            }

            return new GeneralResponse<decimal>
            {
                Success = true,
                Data = id, 
                Message = "Tax deleted successfully"
            };
        }


    }
}
