using FluentResults;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Catalog.API.Repositories {
    public class TheaterRepository {

        private readonly CatalogContext _context;
        public TheaterRepository(CatalogContext context) {
            _context = context;
        }

        public async Task<Result<Theater>> GetById(Guid id) {
        
            var theater = await _context.Theaters
                .Include(t => t.Seats)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (theater is null) {
                return Result.Fail(new TheaterNotFoundError());
            }

            return Result.Ok(theater);
        }
        public async Task<Result<IEnumerable<Theater>>> GetAll() {

            var theater = await _context.Theaters
                .Include(t => t.Seats)
                .ToListAsync();

            return Result.Ok<IEnumerable<Theater>>(theater);
        }
        public async Task<Result> Add(Theater theater) {

            try {

                if (await _context.Theaters
                    .AnyAsync(t => t.Id == theater.Id || t.Number == theater.Number)) {
                    return Result.Fail(new TheaterAlreadyExistsError());
                }

                await _context.Theaters.AddAsync(theater);
                await _context.SaveChangesAsync();

                return Result.Ok();

            } catch(Exception exc) {
                return Result.Fail(exc.Message);
            }
        }
        public async Task<Result> Delete(Guid id) {
            
            try {

                var theater = await _context.Theaters
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (theater is null) {
                    return Result.Fail(new TheaterNotFoundError());
                }
                
                _context.Theaters.Remove(theater);
                await _context.SaveChangesAsync();

                return Result.Ok();

            } catch(Exception exc) {
                return Result.Fail(exc.Message);
            }
        }
    }
}
