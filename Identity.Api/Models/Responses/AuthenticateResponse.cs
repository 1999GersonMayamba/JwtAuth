namespace Identity.Api.Models.Responses
{
    public class AuthenticateResponse
    {
        public string Token { get; set; }
        public DateTime ExpirateAt { get; set; }
    }
}
