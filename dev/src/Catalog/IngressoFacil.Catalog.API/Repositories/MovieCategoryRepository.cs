using FluentResults;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Catalog.API.Repositories {
    public class MovieCategoryRepository {

        private readonly CatalogContext _context;
        public MovieCategoryRepository(CatalogContext context) {
            _context = context;
        }
        public async Task<Result<MovieCategory>> GetById(Guid id) {

            try {

                var category = await _context.Categories.
                    FirstOrDefaultAsync(c => c.Id == id);

                if (category is null) {
                    return Result.Fail(new MovieCategoryNotFoundError());
                }

                return Result.Ok(category);

            } catch (Exception ex) {
                return Result.Fail(ex.Message);
            }
        }
        public async Task<Result<IEnumerable<MovieCategory>>> GetAll() {

            try {

                var categories = await _context.Categories
                    .ToListAsync();

                return Result.Ok<IEnumerable<MovieCategory>>(categories);

            } catch(Exception ex) {
                return Result.Fail(ex.Message);
            }
        }
        public async Task<Result> Add(MovieCategory category) {

            try {

                if (category is null) {
                    return Result.Fail(new ArgumentNullError(nameof(category)));
                }

                if (await _context.Categories
                    .AnyAsync(other => other.Id == category.Id || other.Name == category.Name)) {
                    return Result.Fail(new MovieCategoryAlreadyExistsError());
                }

                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();

                return Result.Ok();

            } catch(Exception ex) {
                return Result.Fail(ex.Message);
            }
        }
        public async Task<Result> Delete(Guid id) {

            try {

                var category = await _context.Categories.
                    FirstOrDefaultAsync(c => c.Id == id);

                if (category is null) {
                    return Result.Fail(new MovieCategoryNotFoundError());
                }

                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();

                return Result.Ok();

            } catch(Exception ex) {
                return Result.Fail(ex.Message);
            }
        } 
    }
}
