namespace IngressoFacil.Catalog.API.Models {
    public class Theater {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public ICollection<Seat> Seats { get; set; } = new List<Seat>();
    }
}
