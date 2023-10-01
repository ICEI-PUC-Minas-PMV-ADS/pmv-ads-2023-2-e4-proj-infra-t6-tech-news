using FluentResults;

namespace IngressoFacil.Authentication.API.Errors {
    public class PasswordIsBlankError : Error {
        public PasswordIsBlankError() : base("A senha não pode estar em branco.") { } 
    }
    public class PasswordIsInvalidError : Error {
        public PasswordIsInvalidError() : base("A senha não atende os requisitos mínimos.") { }
    }
}
