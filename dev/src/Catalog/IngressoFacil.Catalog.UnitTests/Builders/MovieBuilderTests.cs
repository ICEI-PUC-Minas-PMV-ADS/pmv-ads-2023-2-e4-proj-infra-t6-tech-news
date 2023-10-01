using IngressoFacil.Catalog.API.Builders;
using IngressoFacil.Catalog.API.Common.Errors;
using IngressoFacil.Catalog.API.Errors;

namespace IngressoFacil.Catalog.UnitTests.Builders {

    [TestClass]
    public class MovieBuilderTests {

        private readonly MovieBuilder _builder;
        public MovieBuilderTests() {
            _builder = new MovieBuilder();
        }

        [TestMethod]
        public void Build_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.Build());
        }

        [TestMethod]
        public void WithTitle_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithTitle(string.Empty));
        }

        [TestMethod]
        public void WithTitle_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var buildResult = _builder.
                CreateNew().
                WithTitle(null).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void WithTitle_BlankTitle_ReturnsFailureWithPropertyIsBlankError() {

            var buildResult = _builder.
                CreateNew().
                WithTitle(string.Empty).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyIsBlankError));
        }

        [TestMethod]
        public void WithTitle_TitleLengthTooShort_ReturnsFailureWithPropertyLengthTooShortError() {

            var buildResult = _builder.
                CreateNew().
                WithTitle("ra").
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyLengthTooShortError));
        }

        [TestMethod]
        public void WithTitle_TitleLengthTooLong_ReturnsFailureWithPropertyLengthTooLongError() {

            var buildResult = _builder.
                CreateNew().
                WithTitle("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyLengthTooLongError));
        }

        [TestMethod]
        public void WithTitle_ValidTitle_ReturnsSuccessWithNotNullValue() {

            var buildResult = _builder.
                CreateNew().
                WithTitle("The User").
                Build();

            Assert.IsTrue(buildResult.IsSuccess);
            Assert.IsNotNull(buildResult.ValueOrDefault);
        }
    }
}
