using AutoMapper;
using SignalRProject.Dto.MessageDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<Message, ResultMessageDto>();
            CreateMap<Message, GetMessageDto>();
            CreateMap<Message, CreateMessageDto>();
            CreateMap<Message, UpdateMessageDto>();
        }
    }
}
