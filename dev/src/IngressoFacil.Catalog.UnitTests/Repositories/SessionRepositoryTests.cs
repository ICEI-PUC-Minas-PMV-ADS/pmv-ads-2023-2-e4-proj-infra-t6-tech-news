using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Repositories;

namespace IngressoFacil.Catalog.UnitTests.Repositories {

    [TestClass]
    public class SessionRepositoryTests {

        private readonly SessionRepository _repository;
        public SessionRepositoryTests() {
            _repository = new SessionRepository(DevSettings.GetInMemoryDatabase());
        }

        [TestMethod]
        public void GetById_SessionThatNotExists_ReturnsFailureWithSessionNotFoundError() {

            var getResult = _repository.GetById(Guid.Parse("4a3dfe58-6a8c-41ff-966b-b40fa132dcef")).RunSync();

            Assert.IsTrue(getResult.IsFailed);
            Assert.IsInstanceOfType(getResult.Errors[0], typeof(SessionNotFoundError));
        }

        [TestMethod]
        public void GetById_SessionThatExists_ReturnsSuccessWithValue() {

            var getResult = _repository.GetById(Guid.Parse("1026b2bb-8119-4830-b76e-9b9e51ad41ad")).RunSync();

            Assert.IsTrue(getResult.IsSuccess);
            Assert.IsNotNull(getResult.ValueOrDefault);
        }
    }
}
