using ERAAPI.Data;
using ERAAPI.DTO;
using ERAAPI.DTO.LoginDTO;
using ERAAPI.Helpers;
using ERAAPI.Repositories.Interfaces;
using ERAAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ERAAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        EraPosDbNewLastContext _eraPosDbNewLastContext;
        private readonly IAuthRepository _authRepository;
        private readonly IJwtService _jwtService;
        private string _EncryptKey;
        public AuthController(EraPosDbNewLastContext eraPosDbNewLastContext,
            IAuthRepository authRepository, IJwtService jwtService,
            IConfiguration configuration)
        {
            _authRepository = authRepository;
            _jwtService = jwtService;
            _EncryptKey = configuration["EncryptKey"];
        }



        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequestDTO request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new LoginResponseDTO
                    {
                        Success = false,
                        Message = "Invalid input data"
                    });
                }

                string encryptedPassword = EncryptOrDecrypt.EncryptString(request.Password, _EncryptKey);
                var user = _authRepository.GetUserByUserNameAndPassword(request.UserName, encryptedPassword.Trim());

                if (user == null)
                {
                    return Unauthorized(new LoginResponseDTO
                    {
                        Success = false,
                        Message = "Username or password is incorrect"
                    });
                }

                var token = _jwtService.GenerateToken(user.UserName, user.UserId,user.RoleId);

                return Ok(new LoginResponseDTO
                {
                    Success = true,
                    Message = "Login successful",
                    Token = token,
                    UserId = user.UserId,
                    UserName = user.UserName,
                    RoleId = user.RoleId
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new LoginResponseDTO
                {
                    Success = false,
                    Message = "LOGIN02: " + ex.Message
                });
            }
        }
 
    
    
    }
}






