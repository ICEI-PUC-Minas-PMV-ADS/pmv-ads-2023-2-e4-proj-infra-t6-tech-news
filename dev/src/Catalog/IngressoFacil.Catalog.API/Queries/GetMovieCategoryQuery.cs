namespace IngressoFacil.Catalog.API.Queries {
    public class GetMovieCategoryQuery {
        public GetMovieCategoryQuery(Guid id) {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
