using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Models;
using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.UnitTests.Repositories {

    [TestClass]
    public class MovieRepositoryTests {

        private readonly MovieRepository _repository;
        public MovieRepositoryTests() {
            _repository = new MovieRepository(DevSettings.GetInMemoryDatabase());
        }

        [TestMethod]
        public void GetById_MovieThatNotExists_ReturnsFailureWithMovieNotFoundError() {

            var getResult = _repository.
                GetById(Guid.NewGuid()).RunSync();

            Assert.IsTrue(getResult.IsFailed);
            Assert.IsInstanceOfType(getResult.Errors[0], typeof(MovieNotFoundError));
        }

        [TestMethod]
        public void GetById_MovieThatExists_ReturnsSuccessWithNotNullValue() {

            var getResult = _repository.
                GetById(Guid.Parse("cfe49634-54ac-47a5-8516-42034036bd6e")).RunSync();

            Assert.IsTrue(getResult.IsSuccess);
            Assert.IsNotNull(getResult.ValueOrDefault);
        }

        [TestMethod]
        public void Add_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var addResult = _repository.Add(null).RunSync();

            Assert.IsTrue(addResult.IsFailed);
            Assert.IsInstanceOfType(addResult.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void Add_MovieThatExists_ReturnsFailureWithMovieAlreadyExistsError() {

            var add = new Movie {
                Id = Guid.Parse("cfe49634-54ac-47a5-8516-42034036bd6e"),
                Title = "Jogador n° 1",
                CategoryId = Guid.Parse("7b2acd10-fbdf-4356-a282-96df8466fded")
            };
            var addResult = _repository.Add(add).RunSync();

            Assert.IsTrue(addResult.IsFailed);
            Assert.IsInstanceOfType(addResult.Errors[0], typeof(MovieAlreadyExistsError));
        }

        [TestMethod]
        public void Add_MovieThatNotExists_ReturnsSuccessWithNotNullValue() {

            var add = new Movie {
                Id = Guid.NewGuid(),
                Title = "Kong fu Panda",
                CategoryId = Guid.Parse("7b2acd10-fbdf-4356-a282-96df8466fded")
            };
            var addResult = _repository.Add(add).RunSync();

            Assert.IsTrue(addResult.IsSuccess);
            Assert.IsNotNull(addResult.ValueOrDefault);
        }

        [TestMethod]
        public void Delete_MovieThatNotExists_ReturnsFailureWithMovieNotFoundError() {

            var deleteResult = _repository.Delete(Guid.NewGuid()).RunSync();

            Assert.IsTrue(deleteResult.IsFailed);
            Assert.IsInstanceOfType(deleteResult.Errors[0], typeof(MovieNotFoundError));
        }

        [TestMethod]
        public void Delete_MovieThatExists_ReturnsSuccessWithNotNullValue() {

            var deleteResult = _repository.Delete(Guid.Parse("8a282558-799e-48f0-a77a-2dfba04e98a0")).RunSync();

            Assert.IsTrue(deleteResult.IsSuccess);
        }
    }
}
