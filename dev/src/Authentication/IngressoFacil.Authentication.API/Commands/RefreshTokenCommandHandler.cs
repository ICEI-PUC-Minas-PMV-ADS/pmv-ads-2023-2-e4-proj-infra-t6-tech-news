using FluentResults;
using IngressoFacil.Authentication.API.Errors;
using IngressoFacil.Authentication.API.Models;

namespace IngressoFacil.Authentication.API.Commands {
    public partial class AuthenticationCommandHandler {
        public async Task<Result<RefreshTokenCommandResult>> Handle(RefreshTokenCommand command) {

            var principal = _tokenService.GetPrincipalFromExpiredToken(command.Token);
            var userEmail = principal.Identity.Name;
            var getRefreshTokenResult = await _refreshTokenRepository.GetAsync(userEmail);

            if (getRefreshTokenResult.IsFailed) {
                return Result.Fail(getRefreshTokenResult.Errors);
            }

            if (getRefreshTokenResult.Value.ToString() != command.RefreshToken) {
                return Result.Fail(new RefreshTokenIsNotValidError());
            }

            var newToken = _tokenService.GenerateToken(principal.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            await _refreshTokenRepository.DeleteAsync(newRefreshToken);
            await _refreshTokenRepository.SaveAsync(new RefreshToken { Token = newRefreshToken, UserEmail = userEmail });

            return Result.Ok(new RefreshTokenCommandResult { RefreshToken = newRefreshToken, Token = newToken });
        }
    }
}
