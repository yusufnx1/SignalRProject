﻿namespace SignalRProject.Entities.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? TableNumber { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }
}
