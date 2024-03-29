﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRProject.Entities.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? TableNumber { get; set; }
        public string? Description { get; set; }
        [Column(TypeName ="Date")]
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }
}
