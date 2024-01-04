using AutoMapper;
using SignalRProject.Dto.ProductDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWhitCategory>()
                .ForMember(e => e.CategoryName, o => o.MapFrom(d => d.Category.CategoryName))
                .ReverseMap();
        }
    }
}
