using AutoMapper;
using SignalRProject.Dto.ContactUsDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Mapping
{
    public class ContactUsMapping : Profile
    {
        public ContactUsMapping()
        {
            CreateMap<ContactUs, ResultContactDto>().ReverseMap(); ;
            CreateMap<ContactUs, GetContactUsDto>().ReverseMap(); ;
            CreateMap<ContactUs, UpdateContactDto>().ReverseMap(); ;
            CreateMap<ContactUs, CreateContactDto>().ReverseMap(); ;
        }
    }
}
