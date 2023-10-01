using FluentResults;

namespace IngressoFacil.Catalog.API.Commands
{
    public partial class SessionCommandHandler
    {
        public async Task<Result> Handle(EndSessionCommand command)
        {
            try
            {
                var GetResult = await _sessionRepository.GetById(command.Id);
                if (GetResult.IsFailed)
                {
                    return Result.Fail(GetResult.Errors);
                }
                var SessionResult = GetResult.Value;
                SessionResult.IsFinished = true;

                var UpdateResult = await _sessionRepository.Update(SessionResult);

                if (UpdateResult.IsFailed)
                {
                    return Result.Fail(UpdateResult.Errors);
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