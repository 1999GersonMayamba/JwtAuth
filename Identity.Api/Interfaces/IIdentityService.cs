using Identity.Api.Models.Responses;

namespace Identity.Api.Interfaces
{
    public interface IIdentityService
    {
        AuthenticateResponse GenerateJwtToken(string username);
    }
}
