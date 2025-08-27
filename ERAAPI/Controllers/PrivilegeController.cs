using ERAAPI.Models;
using ERAAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERAAPI.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PrivilegeController : ControllerBase
    {
        private readonly PrivilegeService _privilegeService;

        public PrivilegeController(PrivilegeService privilegeService)
        {
            _privilegeService = privilegeService;
        }



        [HttpGet("byrole/{roleId}")]
        public async Task<ActionResult<List<Privilege>>> GetPrivilegesByRole(decimal roleId)
        {
            var privileges = await _privilegeService.GetPrivilegesByRoleAsync(roleId);
            return Ok(privileges);
        }
    }
}
