using IngressoFacil.Authentication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Authentication.API.Infrastructure {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
