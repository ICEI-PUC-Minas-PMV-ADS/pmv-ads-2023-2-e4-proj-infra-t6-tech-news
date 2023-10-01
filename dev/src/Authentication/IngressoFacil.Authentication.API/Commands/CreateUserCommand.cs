namespace IngressoFacil.Authentication.API.Commands {
    public class CreateUserCommand {
        public CreateUserCommand(string userEmail, string userPassword) {
            UserEmail = userEmail;
            UserPassword = userPassword;
        }

        public string UserEmail { get; }
        public string UserPassword { get; }
    }
}
