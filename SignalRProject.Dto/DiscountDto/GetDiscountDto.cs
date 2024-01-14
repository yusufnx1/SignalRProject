﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Dto.DiscountDto
{
    public class GetDiscountDto
    {
        public int DiscountId { get; set; }
        public string? Title { get; set; }
        public int Amount { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
