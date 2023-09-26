using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Catalog.API.Infrastructure {
    public class CatalogContextSeed {
        public async Task SeedAsync(CatalogContext context) {

            foreach (var category in DefaultCategories()) {

                if (!await context.Categories
                    .AnyAsync(other => other.Name == category.Name)) {

                    await context.Categories.AddAsync(category);
                }
            }

            foreach (var session in DefaultSession()) {

                if (!await context.Sessions
                    .AnyAsync(other => other.Id == session.Id)) {
                    await context.Sessions.AddAsync(session);
                }
            }

            await context.SaveChangesAsync();
            context.ChangeTracker.Clear();
        }
        public static List<MovieCategory> DefaultCategories() {
            return new List<MovieCategory> {
                new MovieCategory { Id = Guid.Parse("d4ac3d31-1056-4452-a19f-95dafb0c176c"), Name = "Action" },
                new MovieCategory { Id = Guid.Parse("bd2211a2-039d-46d8-9732-4dc08bf7f6a6"), Name = "Terror" },
                new MovieCategory { Id = Guid.Parse("caee58c0-e014-454e-9be8-0cd6a89a1957"), Name = "Commedy" },
                new MovieCategory { Id = Guid.Parse("7b2acd10-fbdf-4356-a282-96df8466fded"), Name = "Fantasy" }
            };
        }

        public static List<Session> DefaultSession() {
            return new List<Session> {
                new Session {
                    Id = Guid.Parse("1026b2bb-8119-4830-b76e-9b9e51ad41ad"),
                    Date = new DateOnly(2030, 10, 30),
                    StartTime = new TimeSpan(12, 30, 0)}
            };
        }
    }
}
