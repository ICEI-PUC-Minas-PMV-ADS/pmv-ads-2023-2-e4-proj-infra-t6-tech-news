using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Queries
{
    public class GetMoviesByCategoryQueryResult
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}
