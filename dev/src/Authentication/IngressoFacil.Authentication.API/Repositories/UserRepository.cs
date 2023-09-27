using FluentResults;
using IngressoFacil.Authentication.API.Infrastructure;
using IngressoFacil.Authentication.API.Errors;
using IngressoFacil.Authentication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Authentication.API.Repositories {
    public sealed class UserRepository {

        private readonly AuthContext _context;
        public UserRepository(AuthContext context) {
            _context = context;
        }

        public Result<User> Get(string email) {

            var user = _context.Users.
                FirstOrDefault(x => x.Email == email);

            if (user is null) {
                return Result.Fail(new UserNotFoundError(email));
            }

            return Result.Ok(user);
        }
        public async Task<Result<User>> GetAsync(string email) {

            var user = await _context.Users.
                FirstOrDefaultAsync(x => x.Email == email);

            if (user is null) {
                return Result.Fail(new UserNotFoundError(email));
            }

            return Result.Ok(user);
        }
        public Result<IEnumerable<User>> GetAll() {
            return _context.Users.ToList();
        }
        public async Task<Result<IEnumerable<User>>> GetAllAsync() {
            return await _context.Users.ToListAsync();
        }
        public Result Add(User user) {

            if (user is null) {
                return Result.Fail(new ArgumentNullError(nameof(user)));
            }

            if (_context.Users.
                Any(other => other.Email == user.Email)) {
                return Result.Fail(new UserAlreadyExistsError(user.Email));
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return Result.Ok();
        }
        public async Task<Result> AddAsync(User user) {

            if (user is null) {
                return Result.Fail(new ArgumentNullError(nameof(user)));
            }

            if (await _context.Users.
                AnyAsync(other => other.Email == user.Email)) {
                return Result.Fail(new UserAlreadyExistsError(user.Email));
            }

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return Result.Ok();
        }
        public Result Update(User user) {

            if (user is null) {
                return Result.Fail(new ArgumentNullError(nameof(user)));
            }

            if (!_context.Users.
                Any(x => x.Id == user.Id)) {
                return Result.Fail(new UserNotFoundError());
            }

            _context.Users.Update(user);
            _context.SaveChanges();

            return Result.Ok();
        }
        public async Task<Result> UpdateAsync(User user) {

            if (user is null) {
                return Result.Fail(new ArgumentNullError(nameof(user)));
            }

            if (!(await _context.Users.
                AnyAsync(x => x.Id == user.Id))) {
                return Result.Fail(new UserNotFoundError());
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return Result.Ok();
        }
        public Result Remove(string email) {

            var user = _context.Users.
                FirstOrDefault(x => x.Email == email);

            if (user is null) {
                return Result.Fail(new UserNotFoundError(email));
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return Result.Ok();
        }
        public async Task<Result> RemoveAsync(string email) {

            var user = await _context.Users.
                FirstOrDefaultAsync(x => x.Email == email);

            if (user is null) {
                return Result.Fail(new UserNotFoundError(email));
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Result.Ok();
        }
    }
}
