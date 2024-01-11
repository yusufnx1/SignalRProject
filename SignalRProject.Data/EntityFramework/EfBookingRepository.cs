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

		public void BookingStatusApproverd(int id)
		{
			using var context = new SignalRContext();
			var value = context.Bookings.Find(id);
			value.Description = "Rezervasyon Onaylandı.";
			context.SaveChanges();
		}

		public void BookingStatusCancelled(int id)
		{
			using var context = new SignalRContext();
			var value = context.Bookings.Find(id);
			value.Description = "Rezervasyon İptal Edildi.";
			context.SaveChanges();
		}
	}
}
