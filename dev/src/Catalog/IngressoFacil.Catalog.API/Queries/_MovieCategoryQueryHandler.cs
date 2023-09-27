using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.API.Queries {
    public partial class MovieCategoryQueryHandler {

        private readonly MovieCategoryRepository _repository;
        public MovieCategoryQueryHandler(MovieCategoryRepository repository) {
            _repository = repository;
        }
    }
}
