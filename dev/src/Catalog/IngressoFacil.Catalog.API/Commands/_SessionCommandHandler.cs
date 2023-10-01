using IngressoFacil.Catalog.API.Builders;
using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.API.Commands
{
    public partial class SessionCommandHandler
    {
        private readonly SessionBuilder _sessionBuilder;

        private readonly SessionRepository _sessionRepository;

        public SessionCommandHandler(SessionRepository repository)
        {
            _sessionRepository = repository;
            _sessionBuilder = new SessionBuilder();
        }
    }
}
    
