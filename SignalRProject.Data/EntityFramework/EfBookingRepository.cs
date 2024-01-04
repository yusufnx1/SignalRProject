using SignalRProject.Data.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Data.Repositories;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.EntityFramework
{
    public class EfBookingRepository : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingRepository(SignalRContext context) : base(context)
        {
        }
    }
}
