using System.ComponentModel.DataAnnotations;

namespace IngressoFacil.Authentication.API.Models {
    public class User {
        public User() {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
