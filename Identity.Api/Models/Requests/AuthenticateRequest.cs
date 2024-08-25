namespace Identity.Api.Models.Requests
{
    public class AuthenticateRequest
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}
