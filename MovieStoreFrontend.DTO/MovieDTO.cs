#nullable disable

namespace MovieStoreFrontend.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal RentalPrice { get; set; }

        public decimal PurchasePrice { get; set; }
    }
}
