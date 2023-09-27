namespace IngressoFacil.Authentication.API.Commands {
    public class LoginCommand {
        public LoginCommand(string userEmail, string password) {
            UserEmail = userEmail;
            Password = password;
        }

        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}
