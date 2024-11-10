using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using xAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace xAPI.Services
{
    // interface: ITokenService | to expose methods without implementation
    public interface ITokenService
    {
        public string GenerateJwtToken(string username);
    }

    // class: TokenService | to consume service methods
    public class TokenService : ITokenService
    {
        // variable: configuration | to access global enviornment variables
        private readonly IConfiguration _configuration;

        // constructor: TokenService | to initialize class variables
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /*
        *   method: GenerateJwtToken
        *   type: service
        *   purpose: to generate JWT bearer token
        *   parameter: username as string
        *   return: bearer token as json object
        */
        public string GenerateJwtToken(string username)
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