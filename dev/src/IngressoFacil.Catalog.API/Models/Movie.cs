namespace IngressoFacil.Catalog.API.Models {
    public class Movie {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public Guid CategoryId { get; set; }
        public MovieCategory? Category { get; set; }
    }
}
