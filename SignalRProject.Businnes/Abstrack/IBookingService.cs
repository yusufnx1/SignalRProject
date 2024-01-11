using SignalRProject.Entities.Entities;

namespace SignalRProject.Businnes.Abstrack
{
    public interface IBookingService : IGenericService<Booking>
    {
		void BookingStatusApproverd(int id);
		void BookingStatusCancelled(int id);
	}
}
