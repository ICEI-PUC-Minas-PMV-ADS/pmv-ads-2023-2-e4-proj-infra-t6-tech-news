using IngressoFacil.Catalog.API.Builders;
using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.API.Commands {
    public partial class MovieCategoryCommandHandler {
        private readonly MovieCategoryRepository _repository;
        private readonly MovieCategoryBuilder _builder;
        public MovieCategoryCommandHandler(MovieCategoryRepository repository) {
            _repository = repository;
            _builder = new MovieCategoryBuilder();
        }
    }
}
