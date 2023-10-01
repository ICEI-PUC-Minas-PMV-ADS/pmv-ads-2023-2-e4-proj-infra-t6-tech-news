using FluentResults;

namespace IngressoFacil.Authentication.API.Errors {
    public class UserNotFoundError : Error {
        public UserNotFoundError() : base($"User not found.") { }
        public UserNotFoundError(string user) : base($"User '{user}' not found.") { }
    }
    public class UserAlreadyExistsError : Error {
        public UserAlreadyExistsError(string user) : base($"User '{user}' already exists.") { }
    }
    public class UserPasswordIsInvalid : Error {
        public UserPasswordIsInvalid() : base($"Senha incorreta.") { }
    }
}
