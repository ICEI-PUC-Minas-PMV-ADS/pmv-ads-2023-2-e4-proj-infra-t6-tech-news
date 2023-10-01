using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.API.Queries
{
    public partial class MovieQueryHandler
    {
        private readonly MovieRepository repository;
        public MovieQueryHandler(MovieRepository repository) { 
            this.repository = repository;   
        }
    }
}
