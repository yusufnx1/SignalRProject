﻿using System.ComponentModel.DataAnnotations;

namespace SignalRProject.Entities.Entities
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MenuTableId { get; set; }
        public MenuTable MenuTable { get; set; }
    }
}
