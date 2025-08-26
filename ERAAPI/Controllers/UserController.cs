using ERAAPI.Attributes;
using ERAAPI.DTO;
using ERAAPI.DTO.UserDTO;
using ERAAPI.Helpers;
using ERAAPI.Models;
using ERAAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ERAAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _userRepository;
        public UserController(IUser user)
        {
            _userRepository = user;
        }


        [HttpPost("SaveOrUpdateUser")]
        [AuthorizePrivilege("User Creation", "Update")]
        public IActionResult SaveOrUpdateUser([FromBody] UserRequestDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new GeneralResponse<string>
                {
                    Success = false,
                    Data = null,
                    Message = "Invalid input data"
                });
            }

            try
            {
                // جلب UserId من التوكن
                var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                decimal currentUserId = 0;
                if (userIdClaim != null && decimal.TryParse(userIdClaim.Value, out var parsedId))
                {
                    currentUserId = parsedId;
                }


                var userInfo = new UserInfo
                {
                    UserId = userDto.UserId,
                    UserName = userDto.UserName,
                    Password = EncryptOrDecrypt.EncryptString(userDto.Password, "NaiSoft"),
                    Active = userDto.Active,
                    RoleId = userDto.RoleId,
                    EmployeeId = userDto.EmployeeId,
                    ManagerId = userDto.ManagerId,
                    BankId = userDto.BankId,
                    GodownId = userDto.GodownId,
                    Narration = userDto.Narration,
                    Extra1 = userDto.Extra1,
                    Extra2 = userDto.Extra2,
                    ExtraDate = userDto.ExtraDate,
                    CreatedBy = currentUserId,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedBy = currentUserId,
                    ModifiedDate = DateTime.UtcNow
                };

                decimal id = _userRepository.UserSaveAndUpdate(userInfo);

                var responseDto = new UserResponseDto
                {
                    UserId = id,
                    UserName = userInfo.UserName,
                    Active = userInfo.Active,
                    RoleId = userInfo.RoleId,
                    EmployeeId = userInfo.EmployeeId,
                    ManagerId = userInfo.ManagerId,
                    BankId = userInfo.BankId,
                    GodownId = userInfo.GodownId,
                    Narration = userInfo.Narration,
                    Extra1 = userInfo.Extra1,
                    Extra2 = userInfo.Extra2,
                    ExtraDate = userInfo.ExtraDate
                };

                return Ok(new GeneralResponse<UserResponseDto>
                {
                    Success = true,
                    Data = responseDto,
                    Message = "User saved successfully"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new GeneralResponse<string>
                {
                    Success = false,
                    Data = null,
                    Message = "An error occurred: " + ex.Message
                });
            }
        }


    }
}
