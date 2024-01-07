using SignalRProject.Entities.Entities;

namespace SignalRProject.Web.Dto.BasketDto
{
    public class ResultBasketDto
    {

        public int BasketId { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
    }
}
