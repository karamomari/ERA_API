using ERAAPI.DTO;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERAAPI.Controllers
{
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
    }
}
