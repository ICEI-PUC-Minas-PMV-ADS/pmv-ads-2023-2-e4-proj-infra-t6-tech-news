using FluentResults;
using IngressoFacil.Catalog.API.Common.Errors;
using IngressoFacil.Catalog.API.Common.Validations;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Builders {
    public class MovieBuilder {
        private Movie _movie;
        private Result<Movie> _result;
        public MovieBuilder CreateNew() {
            _movie = new Movie();
            _result = new Result<Movie>();

            return this;
        }
        public MovieBuilder WithTitle(string title) {

            if (_result is null || _movie is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new movie.");
            }

            if (title is null) {
                _result.WithError(new ArgumentNullError(nameof(title)));
                return this;
            }

            PropertyValidations.Normalize(ref title);

            if (PropertyValidations.IsBlank(title)) {
                _result.WithError(new PropertyIsBlankError(nameof(title)));
                return this;
            }

            if (!PropertyValidations.HasMinLength(title, 3)) {
                _result.WithError(new PropertyLengthTooShortError(nameof(title), 3));
                return this;
            }

            if (!PropertyValidations.HasMaxLength(title, 20)) {
                _result.WithError(new PropertyLengthTooLongError(nameof(title), 20));
                return this;
            }

            _movie.Title = title;

            return this;
        }
        public Result<Movie> Build() {

            if (_result is null || _movie is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new movie.");
            }

            if (_result.IsSuccess) {
                _result.WithValue(_movie);
            }

            return _result;
        }
    }
}
