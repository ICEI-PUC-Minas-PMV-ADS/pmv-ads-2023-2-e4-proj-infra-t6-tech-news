using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class ArgumentNullError : Error {
        public ArgumentNullError(string argument) : base($"The {argument} argument cannot be null.") {
        }
    }
}
