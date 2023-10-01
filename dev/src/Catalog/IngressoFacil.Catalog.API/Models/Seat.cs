namespace IngressoFacil.Catalog.API.Models {
    public class Seat {
        public Guid Id { get; set; } = new Guid();
        public Guid TheaterId { get; set; }
        public string Code { get; set; }
        public bool IsReservated { get; set; }
    }
}
