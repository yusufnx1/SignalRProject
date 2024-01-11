using AutoMapper;
using SignalRProject.Dto.SliderDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Mapping
{
	public class SlidersMapping : Profile
	{
        public SlidersMapping()
        {
            CreateMap<Slider, ResultSliderDto>();
            CreateMap<Slider, CreateSliderDto>();
            CreateMap<Slider, UpdateSliderDto>();
        }
    }
}
