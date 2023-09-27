using FluentResults;
using IngressoFacil.Authentication.API.Models;

namespace IngressoFacil.Authentication.API.Commands {
    public partial class AuthenticationCommandHandler {
        public async Task<Result<CreateUserCommandResult>> Handle(CreateUserCommand command) {

            var buildUserResult = _userBuilder.
                CreateNew().
                WithEmail(command.UserEmail).
                WithPassword(command.UserPassword).
                EncryptPassword().
                Build();

            if (buildUserResult.IsFailed) {
                return Result.Fail(buildUserResult.Errors);
            }

            var user = buildUserResult.Value;
            var addUserResult = await _userRepository.AddAsync(user);

            if (addUserResult.IsFailed) {
                return Result.Fail(addUserResult.Errors);
            }

            var token = _tokenService.GenerateToken(user);
            var refreshToken = _tokenService.GenerateRefreshToken();

            var saveRefreshTokenResult = await _refreshTokenRepository.
                SaveAsync(new RefreshToken { Token = refreshToken, UserEmail = user.Email });

            if (saveRefreshTokenResult.IsFailed) {
                return Result.Fail(saveRefreshTokenResult.Errors);
            }

            return Result.Ok(new CreateUserCommandResult {
                Token = token,
                UserEmail = user.Email,
                RefreshToken = refreshToken,
            });
        }
    }
}
