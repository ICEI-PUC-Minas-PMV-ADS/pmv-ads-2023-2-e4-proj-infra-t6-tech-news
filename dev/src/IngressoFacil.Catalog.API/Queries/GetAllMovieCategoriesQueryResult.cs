using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Queries {
    public class GetAllMovieCategoriesQueryResult {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public IEnumerable<MovieCategory>? Categories { get; set; }
    }
}
