﻿using System.ComponentModel.DataAnnotations;

namespace SignalRProject.Entities.Entities
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
