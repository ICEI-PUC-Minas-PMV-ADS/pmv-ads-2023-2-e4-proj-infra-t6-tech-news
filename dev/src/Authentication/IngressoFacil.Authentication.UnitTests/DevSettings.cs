using IngressoFacil.Authentication.API.Infrastructure;
using IngressoFacil.Authentication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoFacil.Authentication.UnitTests {
    internal static class DevSettings {

        private static AuthContext InMemoryDatabaseInstance;
        public static AuthContext GetInMemoryDatabase(bool seedDatabase) {

            if (InMemoryDatabaseInstance is not null) {
                return InMemoryDatabaseInstance;
            }

            var options = new DbContextOptionsBuilder<AuthContext>().
                UseInMemoryDatabase("inventory-control").
                UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).
                Options;

            var database = new AuthContext(options);

            if (seedDatabase) {
                SeedDatabase(database);
            }

            InMemoryDatabaseInstance = database;

            return database;
        }

        private static void SeedDatabase(AuthContext context) {
            context.Users.AddRange(DefaultUsers());
            context.RefreshTokens.AddRange(DefaultRefreshTokens());
            context.SaveChanges();

            context.ChangeTracker.Clear();
        }

        private static List<User> DefaultUsers() {
            return new List<User> {
                new User() { Id = Guid.Parse("ba56273d-0c8b-4ea6-90ac-691494d1f402"), Email = "batman@mail.com", Password = "Teste@123" },
                new User() { Id = Guid.Parse("b6a5e02a-40cd-4a47-960c-1a189ecd821a"), Email = "robin@mail.com", Password = "Teste@123" },
            };
        }
        private static List<RefreshToken> DefaultRefreshTokens() {
            return new List<RefreshToken> {
                new RefreshToken() { UserEmail = "batman@mail.com", Token = "MHFzdzNjaWtzMTE2MDBrMTB1ZXdlbWgzZnNha3BvYTQ2Y2Z1emxseG90cWd4aDRvZmJ3dDEzbzl4Zjg1czZpcTRmMG13dnc4MTg3cjkyNHRyeTB1aXFpdWEzMG1qdGY1ZTA0MjR6aDBwMWZybnAwejFzb2M1eXRwOXFiMTkwdHM=" },
                new RefreshToken() { UserEmail = "robin@mail.com", Token = "bDcwangyMjJjeTc5ZWQxMjMwdzd4dGxmejQ2ZXBxb2o3cThvbm03N2syMDY3eGJvMm93bzE5ZTV5N2Eyb2kycDlweTZ3bWZuajgycGp3cTNva2g5cHVleGM3NnhmZmZkOGVmdDc2MTdjM2l5MGQyNHU5MmVtY3p1MGZlY2lmcXY=" },
            };
        }
    }
}
