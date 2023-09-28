using FluentResults;
using IngressoFacil.Authentication.API.Errors;
using IngressoFacil.Authentication.API.Infrastructure;
using IngressoFacil.Authentication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Authentication.API.Repositories {
    public class RefreshTokenRepository {

        private readonly AuthContext _context;
        public RefreshTokenRepository(AuthContext context) {
            _context = context;
        }
        public Result Delete(string userEmail) {

            var refreshTokenResult = Get(userEmail);

            if (refreshTokenResult.IsFailed) {
                return Result.Fail(refreshTokenResult.Errors);
            }

            _context.RefreshTokens.Remove(refreshTokenResult.Value);
            _context.SaveChanges();

            return Result.Ok();
        }
        public async Task<Result> DeleteAsync(string userEmail) {

            var refreshTokenResult = await GetAsync(userEmail);

            if (refreshTokenResult.IsFailed) {
                return Result.Fail(refreshTokenResult.Errors);
            }

            _context.RefreshTokens.Remove(refreshTokenResult.Value);
            await _context.SaveChangesAsync();

            return Result.Ok();
        }
        public Result<RefreshToken> Get(string userEmail) {

            if (!_context.RefreshTokens.
                Any(rf => rf.UserEmail == userEmail)) {
                return Result.Fail(new RefreshTokenNotFoundError());
            }

            var refreshToken = _context.RefreshTokens.
                First(rf => rf.UserEmail == userEmail);

            return Result.Ok(refreshToken);
        }
        public async Task<Result<RefreshToken>> GetAsync(string userEmail) {

            if (!(await _context.RefreshTokens.
                AnyAsync(rf => rf.UserEmail == userEmail))) {
                return Result.Fail(new RefreshTokenNotFoundError());
            }

            var refreshToken = await _context.RefreshTokens.
                FirstOrDefaultAsync(rf => rf.UserEmail == userEmail);

            if (refreshToken is null) {
                return Result.Fail(new RefreshTokenNotFoundError());
            }

            return Result.Ok(refreshToken);
        }
        public Result Save(RefreshToken refreshToken) {

            if (refreshToken is null) {
                return Result.Fail(new ArgumentNullError(nameof(refreshToken)));
            }

            if (_context.RefreshTokens.Any(rf => rf.UserEmail == refreshToken.UserEmail)) {
                return Result.Fail(new UserAlreadyHasRefreshTokenError());
            }

            _context.RefreshTokens.Add(refreshToken);
            _context.SaveChanges();

            return Result.Ok();
        }
        public async Task<Result> SaveAsync(RefreshToken refreshToken) {

            if (refreshToken is null) {
                return Result.Fail(new ArgumentNullError(nameof(refreshToken)));
            }

            if (await _context.RefreshTokens.
                AnyAsync(rf => rf.UserEmail == refreshToken.UserEmail)) {
                return Result.Fail(new UserAlreadyHasRefreshTokenError());
            }

            await _context.RefreshTokens.AddAsync(refreshToken);
            await _context.SaveChangesAsync();

            return Result.Ok();
        }
    }
}
