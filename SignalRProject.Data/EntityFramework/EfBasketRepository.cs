using Microsoft.EntityFrameworkCore;
using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Data.EntityFramework
{
    public class EfBasketRepository : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketRepository(SignalRContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByTableNumber(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Where(x => x.MenuTableId == id)
                .Include(y=>y.Product).ToList();
            return values;
        }
    }
}
