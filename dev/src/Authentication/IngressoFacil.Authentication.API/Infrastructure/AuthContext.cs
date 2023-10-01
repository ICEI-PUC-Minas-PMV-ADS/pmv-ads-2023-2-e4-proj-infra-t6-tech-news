using IngressoFacil.Authentication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Authentication.API.Infrastructure {
    public class AuthContext : DbContext {
        public AuthContext(DbContextOptions<AuthContext> options)
            : base(options) {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
