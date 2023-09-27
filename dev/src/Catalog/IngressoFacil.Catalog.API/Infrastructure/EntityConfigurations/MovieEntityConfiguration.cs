using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IngressoFacil.Catalog.API.Infrastructure.EntityConfigurations {
    public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie> {
        public void Configure(EntityTypeBuilder<Movie> builder) {

            builder
                .HasOne(mv => mv.Category)
                .WithMany()
                .HasForeignKey(mv => mv.CategoryId)
                .HasPrincipalKey(cat => cat.Id);
        }
    }
}
