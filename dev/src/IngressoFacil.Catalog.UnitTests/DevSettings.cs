using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Catalog.UnitTests {
    public static class DevSettings {

        private static CatalogContext _instance;
        public static CatalogContext GetInMemoryDatabase() {

            if (_instance is null) {

                var options = new DbContextOptionsBuilder<CatalogContext>()
                    .UseInMemoryDatabase("ingresso-facil-catalog")
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                    .Options;

                _instance = new CatalogContext(options);
            }

            SeedDatabase(_instance);

            return _instance;
        }
        public static void SeedDatabase(CatalogContext database) {

            foreach(var category in DefaultCategories()) {

                if (!database.Categories
                    .Any(other => other.Name == category.Name)) {

                    database.Categories.Add(category);
                }
            }

            foreach (var session in DefaultSession()) {
                
                if (!database.Sessions
                    .Any(other => other.Id == session.Id)) {
                    database.Sessions.Add(session);
                }
            }

            database.SaveChanges();
            database.ChangeTracker.Clear();
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
                    StartTime = new TimeSpan(12, 30, 0),
                    Date = new DateOnly(2030, 10, 30),
                    MovieId = Guid.Parse("b9310bac-88a6-4bea-909b-c02c2b0f0005")}
            };
        }
    }

    public static class AsyncHelper {
        public static TResult RunSync<TResult>(this Task<TResult> task) {
            return task.GetAwaiter().GetResult();
        }
    }
}