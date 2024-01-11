using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.Businnes.Abstrack;
using SignalRProject.Dto.MessageDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _mapper.Map<List<ResultMessageDto>>(_messageService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {
                Mail = createMessageDto.Mail,
                MessageContent = createMessageDto.MessageContent,
                MessageSendDate = DateTime.Now,
                NameSurname = createMessageDto.NameSurname,
                Phone = createMessageDto.Phone,
                Status = true,
                Subject = createMessageDto.Subject,
            };
            _messageService.TAdd(message);
            return Ok("Mesaj Gönderildi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetById(id);
            _messageService.TDelete(value);
            return Ok("Mesaj Silindi");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            Message message = new Message()
            {
                Mail = updateMessageDto.Mail,
                MessageContent = updateMessageDto.MessageContent,
                NameSurname = updateMessageDto.NameSurname,
                Phone = updateMessageDto.Phone,
                Status = true,
                Subject = updateMessageDto.Subject,
                MessageId = updateMessageDto.MessageId
            };
            _messageService.TUpdate(message);
            return Ok("Mesaj Güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var values = _messageService.TGetById(id);
            return Ok(values);
        }
    }
}
