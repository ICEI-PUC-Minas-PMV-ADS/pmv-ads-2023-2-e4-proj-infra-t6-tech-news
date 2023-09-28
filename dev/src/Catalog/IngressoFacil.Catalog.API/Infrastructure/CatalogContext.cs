using IngressoFacil.Catalog.API.Infrastructure.EntityConfigurations;
using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Catalog.API.Infrastructure {
    public class CatalogContext : DbContext {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> Categories { get; set; }
        public DbSet<Session> Sessions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new MovieEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SessionEntityConfiguration());
        }
    }
}
