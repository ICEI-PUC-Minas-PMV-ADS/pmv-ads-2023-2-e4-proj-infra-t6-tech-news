using FluentResults;

namespace IngressoFacil.Catalog.API.Commands
{
    public partial class MovieCategoryCommandHandler
    {
        public async Task<Result> Handle(DeleteCategoryCommand command)
        {
            try 
            {
                var DeleteResult = await _repository.Delete(command.Id);

                if (DeleteResult.IsFailed)
                {
                    return Result.Fail(DeleteResult.Errors);
                }
                return Result.Ok();
            }
            catch(Exception expt) 
            {
                return Result.Fail(expt.Message);
            }
        }
        
       
    }
}
