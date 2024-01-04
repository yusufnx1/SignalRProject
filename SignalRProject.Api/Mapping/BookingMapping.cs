using AutoMapper;
using SignalRProject.Dto.BookingDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
        }
    }
}
