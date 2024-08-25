using Identity.Api.Interfaces;
using Identity.Api.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService _identityService;
        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }


        [HttpPost("token")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest authenticateRequest)
        {
            if (authenticateRequest.User == "admin" && authenticateRequest.Password == "12345678")
            {
                var tokenResponse = _identityService.GenerateJwtToken(authenticateRequest.User);
                return Ok(tokenResponse);
            }

              return BadRequest();
        }
    }
}
