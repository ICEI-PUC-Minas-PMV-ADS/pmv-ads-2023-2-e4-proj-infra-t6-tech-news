using Coravel.Mailer.Mail;

namespace IngressoFacil.Authentication.API.Mailable {
    public class NewUserViewMailable : Mailable<string> {

        private string _email;
        private string _from;
        private string _callbackUrl;
        public NewUserViewMailable(string email, string from, string callbackUrl) {
            _email = email;
            _from = from;
            _callbackUrl = callbackUrl;
        }

        public override void Build() {

            this.To(this._email)
                .From(_from)
                .Subject("Confirme sua conta")
                .Html($"Confirme sua conta clicando no link: <a href=\"{_callbackUrl}\">Link</a>");
        }
    }
}
