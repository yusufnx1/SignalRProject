﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Dto.DiscountDto
{
    public class ResultDiscountDto
    {
        public int DiscountId { get; set; }
        public string? Title { get; set; }
        public int Amount { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
