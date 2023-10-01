using FluentResults;

namespace IngressoFacil.Catalog.API.Commands {
    public partial class MovieCategoryCommandHandler {
        public async Task<CreateMovieCategoryCommandResult> Handle(CreateMovieCategoryCommand command) {

            try {

                var buildResult = _builder
                    .CreateNew()
                    .WithName(command.CategoryName)
                    .Build();

                if (buildResult.IsFailed) {
                    return new CreateMovieCategoryCommandResult {
                        IsSuccess = false,
                        Errors = buildResult.Errors
                    };
                }

                var category = buildResult.Value;
                var addResult = await _repository.Add(category);

                if (addResult.IsFailed) {
                    return new CreateMovieCategoryCommandResult {
                        IsSuccess = false,
                        Errors = addResult.Errors
                    };
                }

                return new CreateMovieCategoryCommandResult {
                    IsSuccess = true,
                    Category = category,
                };

            } catch (Exception ex) {
                return new CreateMovieCategoryCommandResult {
                    IsSuccess = false,
                    Errors = new []{
                        new Error(ex.Message)
                    }
                };
            }
        }
    }
}
