using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Infrastructure;
using IngressoFacil.Catalog.API.Models;
using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.UnitTests.Repositories {

    [TestClass]
    public class MovieCategoryRepositoryTests {

        private readonly MovieCategoryRepository _repository;
        private readonly CatalogContext _context;
        public MovieCategoryRepositoryTests() {
            _context = DevSettings.GetInMemoryDatabase();
            _repository = new MovieCategoryRepository(_context);
        }

        [TestMethod]
        public void Add_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var addResult = _repository.Add(null).RunSync();

            Assert.IsTrue(addResult.IsFailed);
            Assert.IsInstanceOfType(addResult.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void Add_CategoryThatAlreadyExists_ReturnsFailureWithMovieCategoryAlreadyExistsError() {

            var category = new MovieCategory {
                Name = "Terror"
            };

            var addResult = _repository.Add(category).RunSync();

            Assert.IsTrue(addResult.IsFailed);
            Assert.IsInstanceOfType(addResult.Errors[0], typeof(MovieCategoryAlreadyExistsError));
        }

        [TestMethod]
        public void Add_CategoryThatNotExists_ReturnsSuccessAndCategoryIsPersisted() {

            var category = new MovieCategory {
                Id = Guid.Parse("0474fb82-964d-442d-83b0-ec2a105910a3"),
                Name = "Adventure"
            };

            var addResult = _repository.Add(category).RunSync();

            Assert.IsTrue(addResult.IsSuccess);
            Assert.IsTrue(_context.Categories.Contains(category));
        }

        [TestMethod]
        public void Delete_CategoryThatNotExists_ReturnsFailureWithMovieCategoryNotFoundError() {

            var deleteResult = _repository.Delete(Guid.Parse("90393497-e7b6-4a2e-b7bd-2de4c8c7184d")).RunSync();

            Assert.IsTrue(deleteResult.IsFailed);
            Assert.IsInstanceOfType(deleteResult.Errors[0], typeof(MovieCategoryNotFoundError));
        }

        [TestMethod]
        public void Delete_CategoryThatExists_ReturnsSuccessAndDeleteFromContext() {

            var category = new MovieCategory {
                Id = Guid.Parse("d4ac3d31-1056-4452-a19f-95dafb0c176c"),
                Name = "Action"
            };

            var deleteResult = _repository.Delete(category.Id).RunSync();

            Assert.IsTrue(deleteResult.IsSuccess);
            Assert.IsFalse(_context.Categories.Contains(category));
        }

        [TestMethod]
        public void GetById_CategoryThatNotExists_ReturnsFailureWithMovieCategoryNotFoundError() {

            var getResult = _repository.GetById(Guid.Parse("99ebf4ae-45c2-411c-99fb-d7dad0b09c92")).RunSync();

            Assert.IsTrue(getResult.IsFailed);
            Assert.IsInstanceOfType(getResult.Errors[0], typeof(MovieCategoryNotFoundError));
        }

        [TestMethod]
        public void GetById_CategoryThatExists_ReturnsSuccessWithValue() {

            var getResult = _repository.GetById(Guid.Parse("7b2acd10-fbdf-4356-a282-96df8466fded")).RunSync();

            Assert.IsTrue(getResult.IsSuccess);
            Assert.IsNotNull(getResult.ValueOrDefault);
            Assert.AreEqual(getResult.Value.Name, "Fantasy");
        }
    }
}