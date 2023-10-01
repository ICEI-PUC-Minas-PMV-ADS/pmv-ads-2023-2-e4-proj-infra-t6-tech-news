using FluentResults;
using IngressoFacil.Catalog.API.Common.Validations;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Builders {
    public class TheaterBuilder {

        private Theater _theater;
        private Result<Theater> _result;
        public TheaterBuilder CreateNew() {
            _theater = new Theater();
            _result = new Result<Theater>();

            return this;
        }
        public TheaterBuilder WithNumber(int number) {

            if (_result is null || _theater is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new theater.");
            }

            if (PropertyValidations.IsLowerThan(number, 1)) {
                _result.WithError(new TheaterNumberIsNegativeError(number));
                return this;
            }

            _theater.Number = number;
            return this;
        }
        public TheaterBuilder WithSeatsLayout(int rows, int collumns) {

            if (_result is null || _theater is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new theater.");
            }

            var seats = new List<Seat>();

            for(int c = 1; c <= collumns; c++) {
                for(int r = 1; r <= rows; r++) {
                    seats.Add(new Seat {
                        Code = string.Format("{0}{1}", (char)(64 + r), c),
                        IsReservated = false,
                        TheaterId = _theater.Id
                    });
                }
            }

            _theater.Seats = seats;

            return this;
        }
        public Result<Theater> Build() {

            if (_result is null || _theater is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new theater.");
            }

            if (_result.IsSuccess) {
                _result.WithValue(_theater);
            }

            return _result;
        }
    }
}
 