using Identity.Api.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CountryController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Countries()
        {

            List<string> countries = new List<string>
            {
                "Brazil",
                "Canada",
                "Germany",
                "Japan",
                "Australia"
            };

            var htttpContext = HttpContext;

            return Ok(countries);
        }
    }
}
