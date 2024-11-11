using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using xAPI.Services;
using xAPI.Models;

namespace xAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    // class: TokenController | to handle HTTP requests based on business logic
    public class TokenController : ControllerBase
    {   
        // variable: token service | to access services
        private readonly ITokenService _tokenService;

        // variable: account service | to access services
        private readonly IAccountService _accountService;
        
        // constructor: TokenController | to initialize class variables
        public TokenController(ITokenService tokenService, IAccountService accountService)
        {
            _tokenService = tokenService;
            _accountService = accountService;
        }

        /*
        *   Method: GetBearerToken
        *   Purpose: to fetch bearer token
        *   Parameter: login details as object
        *   Return: bearer token as json
        */

        [HttpGet("GetToken")]
        public IActionResult GetBearerToken([FromBody] LoginDetailsModel submittedDetails)
        {
            // check if user exists
            bool isUsernameExists = _accountService.IsEmployeeExists(submittedDetails.UserId, submittedDetails.Password);

            if(isUsernameExists)
            {
                string bearerToken = _tokenService.GenerateJwtToken(submittedDetails.UserId);
                return Ok(new {token = bearerToken});
            }

            return NotFound(new {token = string.Empty});
        }

    }
}