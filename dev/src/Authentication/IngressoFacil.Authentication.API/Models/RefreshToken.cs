using System.ComponentModel.DataAnnotations;

namespace IngressoFacil.Authentication.API.Models {
    public class RefreshToken {
        [Key]
        public Guid Id { get; set; }
        public string UserEmail { get; set; }
        public string Token { get; set; }
        public override string ToString() => Token;
    }
}
