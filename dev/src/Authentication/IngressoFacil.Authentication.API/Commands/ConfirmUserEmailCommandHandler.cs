using FluentResults;

namespace IngressoFacil.Authentication.API.Commands {
    public partial class AuthenticationCommandHandler {
        public async Task<Result> Handle(ConfirmUserEmailCommand command) {

            try {

                var validateResult = _confirmationTokenService
                    .ValidateConfirmationTokenCode(command.ConfirmationToken);

                if (validateResult.IsFailed) {
                    return Result.Fail(validateResult.Errors);
                }

                var getUserResult = await _userRepository.GetAsync(validateResult.Value.Username);

                if (getUserResult.IsFailed) {
                    return Result.Fail(getUserResult.Errors);
                }

                var user = getUserResult.Value;

                user.IsEmailConfirmed = true;

                await _userRepository.UpdateAsync(user);

                return Result.Ok();

            } catch(Exception exc) {
                return Result.Fail(new Error(exc.Message));
            }
        }
    }
}
