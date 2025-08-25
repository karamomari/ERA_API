using ERAAPI.Data;
using ERAAPI.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ERAAPI.Services
{
    public class JwtService : IJwtService
    {
        private readonly string _secretKey;

        public JwtService()
        {
            _secretKey = "ThisIsMyUltraSuperSecretKey_ForJwt1234567890!";
        }

        public string GenerateToken(string username, decimal userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Name, username ?? ""),
                //new Claim(ClaimTypes.Role, user.RoleId?.ToString() ?? "")
            }),
                Expires = DateTime.UtcNow.AddHours(24), 
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
