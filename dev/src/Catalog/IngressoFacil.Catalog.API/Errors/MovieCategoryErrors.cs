using FluentResults;

namespace IngressoFacil.Catalog.API.Errors
{
    public class MovieCategoryAlreadyExistsError : Error
    {
        public MovieCategoryAlreadyExistsError(string CategoryAlredyExists) : base($"A categoria {CategoryAlredyExists} já existe.") { }
    }
    public class MovieCategoryNotFoundError : Error
    {
        public MovieCategoryNotFoundError()  : base($"A categoria não foi encontrada") { }
    }
    public class MovieCategoryNameTooShortError : Error
    {
        public MovieCategoryNameTooShortError(string CategoryNameTooShort) : base($"O nome da categoria {CategoryNameTooShort} é muito curto") { }
    }
    public class MovieCategoryNameTooLongError : Error
    {
        public MovieCategoryNameTooLongError(string CategoryNameTooLong) : base($"O nome da categoria {CategoryNameTooLong}") { }

    }
}
