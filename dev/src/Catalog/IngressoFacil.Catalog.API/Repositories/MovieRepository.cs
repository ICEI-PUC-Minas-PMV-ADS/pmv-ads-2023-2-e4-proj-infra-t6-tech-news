using FluentResults;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Catalog.API.Repositories {
    public class MovieRepository {

        private readonly CatalogContext _context;
        public MovieRepository(CatalogContext context) {
            _context = context;
        }
        public async Task<Result<Movie>> GetById(Guid id) {
            
            var movie = await _context.Movies
                .FirstOrDefaultAsync(x => x.Id == id);

            if (movie is null) {
                return Result.Fail(new MovieNotFoundError());
            }

            return Result.Ok(movie);
        }
        public async Task<Result<IEnumerable<Movie>>> GetAll() {

            var movies = await _context.Movies.ToListAsync();

            return Result.Ok<IEnumerable<Movie>>(movies);
        }
        public async Task<Result<Movie>> Add(Movie movie) {

            if (movie is null) {
                return Result.Fail(new ArgumentNullError(nameof(movie)));
            }


            if (await _context.Movies
                .AnyAsync(m => m.Id == movie.Id)) {
                return Result.Fail(new MovieAlreadyExistsError());
            }

            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();

            return Result.Ok(movie);
        }
        public async Task<Result> Delete(Guid id) {

            var movie = await _context.Movies
                .FirstOrDefaultAsync(x => x.Id == id);
            
            if (movie is null) {
                return Result.Fail(new MovieNotFoundError());
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return Result.Ok();
        }
    }
}
