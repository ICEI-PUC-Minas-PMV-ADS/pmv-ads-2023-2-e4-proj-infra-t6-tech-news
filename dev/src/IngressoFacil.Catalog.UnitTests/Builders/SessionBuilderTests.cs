using IngressoFacil.Catalog.API.Builders;
using IngressoFacil.Catalog.API.Errors;

namespace IngressoFacil.Catalog.UnitTests.Builders {

    [TestClass]
    public class SessionBuilderTests {

        private readonly SessionBuilder _builder;
        public SessionBuilderTests() {
            _builder = new SessionBuilder();
        }

        [TestMethod]
        public void Build_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.Build());
        }

        [TestMethod]
        public void WithStartTime_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithStartTime(TimeSpan.Zero));
        }

        [TestMethod]
        [DataRow(7, 59)]
        [DataRow(22, 30)]
        public void WithStartTime_SessionStartTimeOutsideWorkTimeRange_ResultsFailureWithSessionStartTimeIsNotValidError(int hour, int minute) {

            var buildResult = _builder.
                CreateNew().
                WithStartTime(new TimeSpan(hour, minute, 0)).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(SessionStartTimeIsNotValidError));
        }

        [TestMethod]
        [DataRow(21,59)]
        [DataRow(8, 01)]
        public void WithStartTime_SessionStartTimeInsideWorkTimeRange_ResultsSuccessWithNotNullValue(int hour, int minute) {

            var buildResult = _builder.
                CreateNew().
                WithStartTime(new TimeSpan(hour, minute, 0)).
                Build();

            Assert.IsTrue(buildResult.IsSuccess);
            Assert.IsNotNull(buildResult.ValueOrDefault);
        }


        [TestMethod]
        public void WithDate_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithDate(new DateOnly()));
        }

        [TestMethod]
        [DataRow(2001, 10, 2)]
        [DataRow(2019, 12, 20)]
        public void WithDate_SessionDateBeforeToday_ResultsFailureWithSessionDateBeforeTodayError(int year, int month, int day) {

            var buildResult = _builder.
                CreateNew().
                WithDate(new DateOnly(year, month, day)).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(SessionDateBeforeTodayError));
        }

        [TestMethod]
        [DataRow(2030, 12, 20)]
        public void WithDate_SessionDateAfterToday_ResultsSuccessWithNotNullValue(int year, int month, int day) {

            var buildResult = _builder.
                CreateNew().
                WithDate(new DateOnly(year, month, day)).
                Build();

            Assert.IsTrue(buildResult.IsSuccess);
            Assert.IsNotNull(buildResult.ValueOrDefault);
        }
    }
}
