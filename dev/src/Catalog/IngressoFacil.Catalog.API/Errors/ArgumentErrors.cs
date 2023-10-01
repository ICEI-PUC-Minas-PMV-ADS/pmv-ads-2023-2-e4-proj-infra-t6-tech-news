using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class ArgumentNullError : Error {
        public ArgumentNullError(string argument) : base($"A propriedade {argument} não pode ser nula.") {
        }
    }
}
