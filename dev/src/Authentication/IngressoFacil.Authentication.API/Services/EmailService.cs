using Coravel.Mailer.Mail;
using Coravel.Mailer.Mail.Interfaces;
using IngressoFacil.Authentication.API.Mailable;

namespace IngressoFacil.Authentication.API.Services {
    public class EmailService {

        private readonly IMailer _mailer;
        public readonly string? SenderEmail = "noreply@ingressofacil.com.br";
        public readonly string? UserConfirmEndpoint = "https://localhost:7265/v1/auth/confirmation";
        public EmailService(IMailer mailer) {
            _mailer = mailer;
        }

        public async Task SendUserConfirmationEmailAsync(string userEmail, string confirmationToken) {

            var mailable = new NewUserViewMailable(userEmail, SenderEmail, $"{UserConfirmEndpoint}/{confirmationToken}");
            await _mailer.SendAsync(mailable);
        }
    }
}
