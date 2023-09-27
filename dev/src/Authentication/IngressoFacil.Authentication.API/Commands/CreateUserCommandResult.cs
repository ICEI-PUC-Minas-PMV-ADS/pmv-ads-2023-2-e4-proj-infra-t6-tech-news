using FluentResults;

namespace IngressoFacil.Authentication.API.Commands {
    public class CreateUserCommandResult {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string UserEmail { get; set; }
    }
}
