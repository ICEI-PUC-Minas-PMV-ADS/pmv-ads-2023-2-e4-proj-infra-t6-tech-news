using IngressoFacil.Catalog.API.Builders;
using IngressoFacil.Catalog.API.Errors;

namespace IngressoFacil.Catalog.UnitTests.Builders {

    [TestClass]
    public class TheaterBuilderTests {

        private readonly TheaterBuilder _builder;
        public TheaterBuilderTests() {
            _builder = new TheaterBuilder();
        }

        [TestMethod]
        public void Build_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.Build());
        }

        [TestMethod]
        public void WithNumber_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithNumber(0));
        }

        [TestMethod]
        public void WithNumber_NegativeNumber_ReturnsFailureWithTheaterNumberIsNegativeError() {

            var buildResult = _builder
                .CreateNew()
                .WithNumber(-1)
                .Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(TheaterNumberIsNegativeError));
        }

        [TestMethod]
        public void WithNumber_NonNegativeNumber_ReturnsSuccessWithNotNullValue() {

            var buildResult = _builder
                .CreateNew()
                .WithNumber(2)
                .Build();

            Assert.IsTrue(buildResult.IsSuccess);
            Assert.IsNotNull(buildResult.ValueOrDefault);
        }

        [TestMethod]
        public void WithSeatsLayout_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithSeatsLayout(1, 1));
        }

        [TestMethod]
        public void WithSeatsLayout_TwoByTwoLayout_ReturnsSuccessWithFourSeats() {

            var buildResult = _builder
                .CreateNew()
                .WithSeatsLayout(2, 2)
                .Build();

            Assert.IsTrue(buildResult.IsSuccess);
            Assert.IsNotNull(buildResult.ValueOrDefault);

            var seats = buildResult.Value.Seats.ToArray();

            Assert.AreEqual(seats.Length, 4);
            Assert.AreEqual("A1", seats[0].Code);
            Assert.AreEqual("B1", seats[1].Code);
            Assert.AreEqual("A2", seats[2].Code);
            Assert.AreEqual("B2", seats[3].Code);
        }
    }
}
