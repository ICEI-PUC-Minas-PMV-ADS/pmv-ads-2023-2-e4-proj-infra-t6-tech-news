using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.API.Queries {
    public partial class SessionQueryHandler {

        private readonly SessionRepository _repository;
        public SessionQueryHandler(SessionRepository repository) {
            _repository = repository;
        }
    }
}
