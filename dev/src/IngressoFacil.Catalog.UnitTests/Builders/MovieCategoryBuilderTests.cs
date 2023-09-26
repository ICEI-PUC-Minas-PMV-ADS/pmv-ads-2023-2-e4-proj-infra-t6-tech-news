using IngressoFacil.Catalog.API.Builders;
using IngressoFacil.Catalog.API.Common.Errors;
using IngressoFacil.Catalog.API.Errors;

namespace IngressoFacil.Catalog.UnitTests.Builders {

    [TestClass]
    public class MovieCategoryBuilderTests {

        private readonly MovieCategoryBuilder _builder;
        public MovieCategoryBuilderTests() {
            _builder = new MovieCategoryBuilder();
        }

        [TestMethod]
        public void Build_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.Build());
        }

        [TestMethod]
        public void WithName_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithName(string.Empty));
        }

        [TestMethod]
        public void WithName_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var buildResult = _builder.
                CreateNew().
                WithName(null).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void WithName_BlankName_ReturnsFailureWithPropertyIsBlankError() {

            var buildResult = _builder.
                CreateNew().
                WithName(string.Empty).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyIsBlankError));
        }

        [TestMethod]
        public void WithName_NameLengthTooShort_ReturnsFailureWithPropertyLengthTooShortError() {

            var buildResult = _builder.
                CreateNew().
                WithName("ra").
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyLengthTooShortError));
        }

        [TestMethod]
        public void WithName_NameLengthTooLong_ReturnsFailureWithPropertyLengthTooLongError() {

            var buildResult = _builder.
                CreateNew().
                WithName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyLengthTooLongError));
        }

        [TestMethod]
        public void WithName_ValidName_ReturnsSuccessWithValue() {

            var buildResult = _builder.
                CreateNew().
                WithName("Adventure").
                Build();

            Assert.IsTrue(buildResult.IsSuccess);
            Assert.IsNotNull(buildResult.ValueOrDefault);
            Assert.AreEqual(buildResult.Value.Name, "Adventure");
        }
    }
}
