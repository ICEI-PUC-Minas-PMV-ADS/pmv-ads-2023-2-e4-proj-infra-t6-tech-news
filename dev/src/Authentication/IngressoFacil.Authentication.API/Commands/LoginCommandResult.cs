namespace IngressoFacil.Authentication.API.Commands {
    public class LoginCommandResult {
        public LoginCommandResult(string token, string refreshToken, string userEmail) {
            Token = token;
            RefreshToken = refreshToken;
            UserEmail = userEmail;
        }
        public string Token { get; }
        public string RefreshToken { get; }
        public string UserEmail { get; }
    }
}
