﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRProject.Businnes.Abstrack;
using SignalRProject.Data.Concrete;
using SignalRProject.Dto.ProductDto;
using SignalRProject.Entities.Entities;

namespace SignalRProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWhitCategory
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductId = y.ProductId,
                ProductName = y.ProductName,
                Status= y.Status,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                Status = true,
            });
            return Ok("Ürün Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductId = updateProductDto.ProductId,
                CategoryId = updateProductDto.CategoryId
            });
            return Ok("Ürün Bilgisi Güncellendi");
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }
        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());
        }
        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }
        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }
        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }
        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }
        [HttpGet("ProductPriceByHamburger")]
        public IActionResult ProductPriceByHamburger()
        {
            return Ok(_productService.TProductPriceByHamburger());
        }
    }
}
