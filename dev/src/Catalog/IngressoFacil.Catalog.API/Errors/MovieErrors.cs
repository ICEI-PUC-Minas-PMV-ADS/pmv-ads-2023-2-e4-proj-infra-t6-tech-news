using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class MovieAlreadyExistsError : Error {
    public MovieAlreadyExistsError(string MovieAlreadyExists) : base($"O filme {MovieAlreadyExists} já existe.") { }
    }
    public class MovieNotFoundError : Error {
    public MovieNotFoundError() :base($"O filme não pode ser encontrado.") { }
    }
}
