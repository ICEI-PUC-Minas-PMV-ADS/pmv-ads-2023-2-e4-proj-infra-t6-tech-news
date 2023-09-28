using IngressoFacil.Authentication.API.Errors;
using IngressoFacil.Authentication.API.Models;
using IngressoFacil.Authentication.API.Repositories;

namespace IngressoFacil.Authentication.UnitTests.Repositories {
    [TestClass]
    public class RefreshTokenRepositoryTests {

        private readonly RefreshTokenRepository _repository;
        public RefreshTokenRepositoryTests() {
            _repository = new RefreshTokenRepository(DevSettings.GetInMemoryDatabase(true));
        }

        [TestMethod]
        public void Save_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var addRefreshTokenResult = _repository.Save(null);

            Assert.IsTrue(addRefreshTokenResult.IsFailed);
            Assert.IsInstanceOfType(addRefreshTokenResult.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void Save_RefreshTokenThatAlreadyExists_ReturnsFailureWithUserAlreadyHasRefreshTokenError() {

            var refreshToken = new RefreshToken {
                UserEmail = "batman@mail.com",
                Token = "teste"
            };

            var addRefreshTokenResult = _repository.Save(refreshToken);

            Assert.IsTrue(addRefreshTokenResult.IsFailed);
            Assert.IsInstanceOfType(addRefreshTokenResult.Errors[0], typeof(UserAlreadyHasRefreshTokenError));
        }

        [TestMethod]
        public void Save_RefreshTokenThatNotExists_ReturnsSuccess() {

            var refreshToken = new RefreshToken {
                UserEmail = "tomas@mail.com",
                Token = "teste"
            };

            var addRefreshTokenResult = _repository.Save(refreshToken);

            Assert.IsTrue(addRefreshTokenResult.IsSuccess);
        }

        [TestMethod]
        public void Delete_RefreshTokenThatNotExists_ReturnsFailureWithRefreshTokenNotFoundError() {
            
            var deleteRefreshTokenResult = _repository.Delete("rodrigo@mail.com");

            Assert.IsTrue(deleteRefreshTokenResult.IsFailed);
            Assert.IsInstanceOfType(deleteRefreshTokenResult.Errors[0], typeof(RefreshTokenNotFoundError));
        }

        [TestMethod]
        public void Delete_RefreshTokenThatExists_ReturnsSuccess() {

            var deleteRefreshTokenResult = _repository.Delete("robin@mail.com");

            Assert.IsTrue(deleteRefreshTokenResult.IsSuccess);
        }

        [TestMethod]
        public void Get_RefreshTokenThatNotExists_ReturnsFailureWithRefreshTokenNotFoundError() {

            var getRefreshTokenResult = _repository.Get("rodrigo@mail.com");

            Assert.IsTrue(getRefreshTokenResult.IsFailed);
            Assert.IsInstanceOfType(getRefreshTokenResult.Errors[0], typeof(RefreshTokenNotFoundError));
        }

        [TestMethod]
        public void Get_RefreshTokenThatExists_ReturnsSuccess() {

            var getRefreshTokenResult = _repository.Get("batman@mail.com");

            Assert.IsTrue(getRefreshTokenResult.IsSuccess);
        }
    }
}
