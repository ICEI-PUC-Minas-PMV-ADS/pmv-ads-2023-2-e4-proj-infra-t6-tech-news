using FluentResults;

namespace IngressoFacil.Authentication.API.Commands {
    public partial class AuthenticationCommandHandler {
        public async Task<Result> Handle(SendUserConfirmationCommand command) {

            try {

                var confirmationToken = _confirmationTokenService
                    .GenerateConfirmationTokenCode(new Models.ConfirmationToken {
                        Type = Models.ConfirmationType.EmailConfirmation,
                        Username = command.UserEmail
                    }, 1);

                await _emailService.SendUserConfirmationEmailAsync(command.UserEmail, confirmationToken);

                return Result.Ok();

            } catch (Exception ex) {
                return Result.Fail(new Error(ex.Message));
            }
        }
    }
}
