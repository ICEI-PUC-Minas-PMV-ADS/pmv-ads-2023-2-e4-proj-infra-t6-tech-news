using FluentResults;

namespace IngressoFacil.Authentication.API.Errors {
    public class UserAlreadyHasRefreshTokenError : Error {
        public UserAlreadyHasRefreshTokenError() : base("O usuário já tem um refresh token atribuido.") { }
    }
    public class RefreshTokenNotFoundError : Error {
        public RefreshTokenNotFoundError() : base("Refresh token não encontrado.") { }
    }
    public class RefreshTokenIsNotValidError : Error {
        public RefreshTokenIsNotValidError() : base("O RefreshToken não é válido para o usuário.") { }
    }
}
