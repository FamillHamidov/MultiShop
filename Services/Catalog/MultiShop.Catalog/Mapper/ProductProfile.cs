using AutoMapper;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapper
{
	public class ProductProfile:Profile
	{
        public ProductProfile()
        {
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();
        }
    }
}
