using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class MovieCategoryAlreadyExistsError : Error { }
    public class MovieCategoryNotFoundError : Error { }
    public class MovieCategoryNameTooShortError : Error { }
    public class MovieCategoryNameTooLongError : Error { }
}
