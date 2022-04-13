#nullable disable

namespace MovieStoreFrontend.DTO
{
    public class SaleDTO
    {
        public string Type { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public List<SaleDetailDTO> SaleDetailDtoList { get; set; }
    }
}
