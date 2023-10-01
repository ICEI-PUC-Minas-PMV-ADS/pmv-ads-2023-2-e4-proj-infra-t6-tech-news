using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class MovieAlreadyExistsError : Error {
    public MovieAlreadyExistsError(string MovieAlreadyExists) : base($"O filme {MovieAlreadyExists} já existe.") { }
    }
    public class MovieNotFoundError : Error {
    public MovieNotFoundError(string MovieNotFound) :base($"O filme {MovieNotFound} não pode ser encontrado.") { }
    }
}
