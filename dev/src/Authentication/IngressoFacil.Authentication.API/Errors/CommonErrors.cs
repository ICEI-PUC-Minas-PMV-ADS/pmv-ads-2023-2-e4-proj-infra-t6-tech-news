using FluentResults;

namespace IngressoFacil.Authentication.API.Errors {
    public class ArgumentNullError : Error {
        public ArgumentNullError(string name) : base($"O Argumento '{name}' não pode ser nulo.") { }
    }
}
