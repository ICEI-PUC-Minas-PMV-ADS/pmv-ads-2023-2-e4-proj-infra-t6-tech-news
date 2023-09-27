using IngressoFacil.Authentication.API.Builders;
using IngressoFacil.Authentication.API.Services;
using IngressoFacil.Authentication.API.Errors;

namespace IngressoFacil.Authentication.UnitTests.Builders {

    [TestClass]
    public class UserBuilderTests {

        private UserBuilder _builder;
        public UserBuilderTests() {
            _builder = new UserBuilder(new PasswordService());
        }

        [TestMethod]
        public void Build_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.Build());
        }

        [TestMethod]
        public void WithEmail_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithEmail(""));
        }

        [TestMethod]
        public void WithEmail_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var result = _builder.
                CreateNew().
                WithEmail(null).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void WithEmail_BlankEmail_ReturnsFailureWithEmailIsBlankError() {

            var result = _builder.
                CreateNew().
                WithEmail(string.Empty).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(EmailIsBlankError));
        }

        [TestMethod]
        [DataRow("abc.com")]
        [DataRow("email @teste.com")]
        [DataRow("email@gento")]
        [DataRow("@teste.com")]
        [DataRow("@teste@.com")]
        public void WithEmail_InvalidEmail_ReturnsFailureWithEmailIsInvalidError(string email) {

            var result = _builder.
                CreateNew().
                WithEmail(email).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(EmailIsInvalidError));
        }

        [TestMethod]
        [DataRow("email@domain.com")]
        public void WithEmail_ValidEmail_ReturnsSuccess(string email) {

            var result = _builder.
                CreateNew().
                WithEmail(email).
                Build();

            Assert.IsTrue(result.IsSuccess);
        }

        [TestMethod]
        public void WithPassword_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithPassword(""));
        }

        [TestMethod]
        public void WithPassword_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var result = _builder.
                CreateNew().
                WithPassword(null).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void WithPassword_BlankPassword_ReturnsFailureWithPasswordIsBlankError() {

            var result = _builder.
                CreateNew().
                WithPassword(string.Empty).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(PasswordIsBlankError));
        }

        [TestMethod]
        [DataRow("pas")]
        [DataRow("pas123")]
        [DataRow("pass@123")]
        [DataRow("pass 123")]
        [DataRow("Pass123")]
        [DataRow("123")]
        [DataRow("@123")]
        [DataRow("Pass/123")]
        public void WithPassword_InvalidPassword_ReturnFailureWithPasswordIsInvalidError(string password) {

            var result = _builder.
                CreateNew().
                WithPassword(password).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(PasswordIsInvalidError));
        }

        [TestMethod]
        [DataRow("Pass@123")]
        public void WithPassword_ValidPassword_ReturnSuccess(string password) {

            var result = _builder.
                CreateNew().
                WithPassword(password).
                Build();

            Assert.IsTrue(result.IsSuccess);
        }
    }
}
