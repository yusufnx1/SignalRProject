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

        public void ChangeStatusFalse(int id)
        {
            using var context = new SignalRContext();
            var value = context.Discounts.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void ChangeStatusTrue(int id)
        {
            using var context = new SignalRContext();
            var value = context.Discounts.Find(id);
            value.Status = true;
            context.SaveChanges();
        }
    }
}
