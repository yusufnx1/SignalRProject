using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.EntityFramework
{
    public class EfDiscountRepository : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountRepository(SignalRContext context) : base(context)
        {
        }
    }
}
