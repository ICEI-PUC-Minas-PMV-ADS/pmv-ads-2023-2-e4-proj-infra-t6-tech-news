namespace IngressoFacil.Authentication.API.Commands {
    public class RefreshTokenCommand {
        public RefreshTokenCommand(string token, string refreshToken) {
            Token = token;
            RefreshToken = refreshToken;
        }

        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
