using SignalRProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Businnes.Abstrack
{
    public interface IBasketService:IGenericService<Basket>
    {
        List<Basket> TGetBasketByTableNumber(int id);
    }
}
