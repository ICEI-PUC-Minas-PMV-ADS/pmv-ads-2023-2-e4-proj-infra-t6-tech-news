using FluentResults;
using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Commands {
    public class CreateMovieCategoryCommandResult {
        public bool IsSuccess { get; set; }
        public IEnumerable<IError>? Errors { get; set; }
        public MovieCategory? Category { get; set; }
    }
}
