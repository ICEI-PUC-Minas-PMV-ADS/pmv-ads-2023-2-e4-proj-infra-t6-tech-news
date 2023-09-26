using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IngressoFacil.Catalog.API.Infrastructure.EntityConfigurations {
    public class SessionEntityConfiguration : IEntityTypeConfiguration<Session> {
        public void Configure(EntityTypeBuilder<Session> builder) {
            builder.Property<DateOnly>(s => s.Date)
                .HasColumnType("date")
                .HasConversion<DateOnlyConverter>();
        }

        public class DateOnlyConverter : ValueConverter<DateOnly, DateTime> {
            public DateOnlyConverter() : base(
                    d => d.ToDateTime(TimeOnly.MinValue),
                    d => DateOnly.FromDateTime(d)) { }
        }
    }
}
