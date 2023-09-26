using FluentResults;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Repositories {
    public class SessionRepository {

        private readonly CatalogContext _context;
        public SessionRepository(CatalogContext context) {
            _context = context;
        }
        public async Task<Result<Session>> GetById(Guid id) {

            try {

                var session = _context.Sessions.
                    FirstOrDefault(s => s.Id == id);

                if (session is null) {
                    return Result.Fail(new SessionNotFoundError());
                }

                return Result.Ok(session);

            } catch(Exception exc) {
                return Result.Fail(exc.Message);
            }
        }
    }
}
