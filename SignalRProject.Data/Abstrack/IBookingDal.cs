using SignalRProject.Entities.Entities;

namespace SignalRProject.Data.Abstrack
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusApproverd(int id);
        void BookingStatusCancelled(int id);
    }
}