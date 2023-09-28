using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Queries {
    public class GetMovieCategoryQueryResult {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public MovieCategory? Category { get; set; }
    }
}
