namespace IngressoFacil.Catalog.API.Models {
    public class Session {
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public bool IsFinished { get; set; }
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public Guid TheaterId { get; set; }
        public Theater? Theater { get; set; }
    }
}
