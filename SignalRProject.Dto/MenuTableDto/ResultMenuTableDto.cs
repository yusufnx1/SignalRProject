using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Dto.MenuTableDto
{
    public class ResultMenuTableDto
    {
        public int MenuTableId { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; }
       // public List<Basket> Baskets { get; set; }
    }
}
