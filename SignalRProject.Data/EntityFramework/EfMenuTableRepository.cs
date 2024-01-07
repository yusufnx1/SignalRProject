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
    public class EfMenuTableRepository : GenericRepository<MenuTable>, IMenuTableDal
    {
        public EfMenuTableRepository(SignalRContext context) : base(context)
        {
        }

        public int MenuTableCount()
        {
            using var context = new SignalRContext();
            return context.MenuTables.Count();
        }
    }
}
