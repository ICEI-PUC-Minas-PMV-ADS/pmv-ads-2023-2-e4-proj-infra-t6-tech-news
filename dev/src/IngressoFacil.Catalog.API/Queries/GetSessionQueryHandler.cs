namespace IngressoFacil.Catalog.API.Queries {
    public partial class SessionQueryHandler {
        public async Task<GetSessionQueryResult> Handle(GetSessionQuery query) {

            try {

                var getResult = await _repository.GetById(query.Id);

                if (getResult.IsFailed) {
                    return new GetSessionQueryResult {
                        IsSuccess = false,
                        Message = getResult.Errors[0].Message
                    };
                }

                return new GetSessionQueryResult {
                    IsSuccess = true,
                    Session = getResult.Value
                };

            } catch (Exception ex) {
                return new GetSessionQueryResult {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
