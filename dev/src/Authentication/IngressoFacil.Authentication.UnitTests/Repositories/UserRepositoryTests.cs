using IngressoFacil.Authentication.API.Errors;
using IngressoFacil.Authentication.API.Models;
using IngressoFacil.Authentication.API.Repositories;

namespace IngressoFacil.Authentication.UnitTests.Repositories {
    [TestClass]
    public class UserRepositoryTests {

        private readonly UserRepository _repository;
        public UserRepositoryTests() {
            _repository = new UserRepository(DevSettings.GetInMemoryDatabase(seedDatabase: true));
        }

        [TestMethod]
        public void Add_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var result = _repository.Add(null);

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void Add_UserThatAlreadyExists_ReturnsFailureWithUserAlreadyExistsError() {

            var user = new User();
            user.Email = "batman@mail.com";
            user.Password = "Teste@123";

            var result = _repository.Add(user);

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(UserAlreadyExistsError));
        }

        [TestMethod]
        public void Add_UserThatNotExists_ReturnsSuccess() {

            var user = new User() {
                Email = "gusta@mail.com",
                Password = "Teste@123"
            };

            var addUserResult = _repository.Add(user);

            Assert.IsTrue(addUserResult.IsSuccess);
        }

        [TestMethod]
        public void Update_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var result = _repository.Update(null);

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void Update_UserThatNotExists_ReturnsFailureWithUserNotFoundError() {

            var user = new User() {
                Id = Guid.NewGuid(),
                Email = "teresa@mail.com"
            };

            var result = _repository.Update(user);

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(UserNotFoundError));
        }

        [TestMethod]
        public void Update_UserThatAlreadyExists_ReturnsSuccess() {

            var user = new User() {
                Id = Guid.Parse("b6a5e02a-40cd-4a47-960c-1a189ecd821a"),
                Email = "gusta@mail.com",
                Password = "NewPass@123"
            };

            var updateUserResult = _repository.Update(user);

            Assert.IsTrue(updateUserResult.IsSuccess);
        }

        [TestMethod]
        public void Get_UserThatNotExists_ReturnsFailureWithUserNotFoundError() {

            var result = _repository.Get("ronaldo@mail.com");

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(UserNotFoundError));
        }

        [TestMethod]
        public void Get_UserThatAlreadyExists_ReturnsSuccess() {

            var getUserResult = _repository.Get("batman@mail.com");

            Assert.IsTrue(getUserResult.IsSuccess);
            Assert.IsNotNull(getUserResult.ValueOrDefault);
        }

        [TestMethod]
        public void Remove_UserThatNotExists_ReturnsFailureWithUserNotFoundError() {

            var result = _repository.Remove("ronaldo@mail.com");

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(UserNotFoundError));
        }

        [TestMethod]
        public void Remove_UserThatAlreadyExists_ReturnsSuccess() {

            var removeUserResult = _repository.Remove("batman@mail.com");

            Assert.IsTrue(removeUserResult.IsSuccess);
        }
    }
}
