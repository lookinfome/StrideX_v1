using Microsoft.AspNetCore.Mvc;
using xAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace xAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly Dictionary<string, string> _loginDetailsList = new Dictionary<string, string>();

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
            _loginDetailsList.Add("admin", "admin123");
            _loginDetailsList.Add("user", "user123");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDetailsModel submittedDetails)
        {

            if (_loginDetailsList.ContainsKey(submittedDetails.Username) && _loginDetailsList[submittedDetails.Username] == submittedDetails.Password)
            {
                var token = GenerateJwtToken(submittedDetails.Username);
                Console.WriteLine($"-----------------JWT Bearer Token:{submittedDetails.Username}, {submittedDetails.Password}-------------------");
                Console.WriteLine($"{token}");

                return UserProfile();
            }
            else
            {
                return Unauthorized("Invalid username and password entered!");
            }
        }

        [HttpGet("userprofile")]
        [Authorize]
        public IActionResult UserProfile()
        {
            return Ok("Welcome to StrideXXX!");
        }

        private string GenerateJwtToken(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpiresInMinutes"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
