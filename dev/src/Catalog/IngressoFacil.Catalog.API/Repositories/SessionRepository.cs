using FluentResults;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Models;
using System.Data.Entity;

namespace IngressoFacil.Catalog.API.Repositories {
    public class SessionRepository {

        private readonly CatalogContext _context;
        public SessionRepository(CatalogContext context) {
            _context = context;
        }
        public async Task<Result<Session>> GetById(Guid id) {

            try {

                var session = _context.Sessions
                    .Include(s => s.Movie)
                    .Include(s => s.Theater)
                    .FirstOrDefault(s => s.Id == id);

                if (session is null) {
                    return Result.Fail(new SessionNotFoundError());
                }

                return Result.Ok(session);

            } catch(Exception exc) {
                return Result.Fail(exc.Message);
            }
        }
        public async Task<Result<IEnumerable<Session>>> GetAll() {

            try {

                var sessions = await _context.Sessions
                    .Include(s => s.Movie)
                    .Include(s => s.Theater)
                    .ToListAsync();

                return Result.Ok<IEnumerable<Session>>(sessions);

            } catch(Exception exc) {
                return Result.Fail(exc.Message);
            }
        }
        public async Task<Result> Add(Session session) {

            try {

                if (await _context.Sessions
                        .AnyAsync(s => s.Id == session.Id)) {
                    return Result.Fail(new SessionAlreadyExistsError(session.Id));
                }

                await _context.Sessions.AddAsync(session);
                await _context.SaveChangesAsync();

                return Result.Ok();

            } catch(Exception exc) {
                return Result.Fail(exc.Message);
            }
        }

        public async Task<Result> Update(Session session)
        {

            try
            {

                if (!(await _context.Sessions
                        .AnyAsync(s => s.Id == session.Id)))
                {
                    return Result.Fail(new SessionNotFoundError());
                }

                _context.Sessions.Update(session);
                await _context.SaveChangesAsync();

                return Result.Ok();

            }
            catch (Exception exc)
            {
                return Result.Fail(exc.Message);
            }
        }
    }
}
