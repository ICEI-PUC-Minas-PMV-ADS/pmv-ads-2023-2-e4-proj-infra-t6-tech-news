using FluentResults;
using IngressoFacil.Catalog.API.Common.Errors;
using IngressoFacil.Catalog.API.Common.Validations;
using IngressoFacil.Catalog.API.Errors;
using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Builders {
    public class MovieCategoryBuilder {

        private MovieCategory _category;
        private Result<MovieCategory> _result;
        public MovieCategoryBuilder CreateNew() {
            _category = new MovieCategory();
            _result = new Result<MovieCategory>();

            return this;
        }
        public MovieCategoryBuilder WithName(string name) {

            if (_category is null || _result is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new category.");
            }

            if (name is null) {
                _result.WithError(new ArgumentNullError(nameof(name)));
                return this;
            }

            PropertyValidations.Normalize(ref name);

            if (PropertyValidations.IsBlank(name)) {
                _result.WithError(new PropertyIsBlankError(nameof(name)));
                return this;
            }

            if (!PropertyValidations.HasMinLength(name, 3)) {
                _result.WithError(new PropertyLengthTooShortError(nameof(name), 3));
                return this;
            }

            if (!PropertyValidations.HasMaxLength(name, 20)) {
                _result.WithError(new PropertyLengthTooLongError(nameof(name), 20));
                return this;
            }

            _category.Name = name;

            return this;
        }
        public Result<MovieCategory> Build() {

            if (_result is null || _category is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new category.");
            }

            if (_result.IsSuccess) {
                _result.WithValue(_category);
            }

            return _result;
        }
    }
}
