namespace IngressoFacil.Authentication.API.Models {
    public class ConfirmationToken {
        public string Username { get; set; }
        public ConfirmationType Type { get; set; }
    }

    public enum ConfirmationType {
        EmailConfirmation
    }
}
