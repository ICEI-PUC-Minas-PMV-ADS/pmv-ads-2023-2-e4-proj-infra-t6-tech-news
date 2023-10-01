using FluentResults;
using IngressoFacil.Authentication.API.Errors;
using IngressoFacil.Authentication.API.Models;

namespace IngressoFacil.Authentication.API.Commands {
    public partial class AuthenticationCommandHandler {
        public async Task<Result<LoginCommandResult>> Handle(LoginCommand command) {

            var getUserResult = await _userRepository.
                GetAsync(command.UserEmail);

            if (getUserResult.IsFailed) {
                return Result.Fail(getUserResult.Errors);
            }

            var user = getUserResult.Value;

            if (!_passwordService.VerifyPassword(command.Password, user.Password)) {
                return Result.Fail(new UserPasswordIsInvalid());
            }

            var token = _tokenService.GenerateToken(user);
            var refreshToken = _tokenService.GenerateRefreshToken();

            await _refreshTokenRepository.DeleteAsync(user.Email);
            await _refreshTokenRepository.SaveAsync(new RefreshToken { Token = refreshToken, UserEmail = user.Email });

            return Result.Ok(new LoginCommandResult(token, refreshToken, user.Email));
        }
    }
}
