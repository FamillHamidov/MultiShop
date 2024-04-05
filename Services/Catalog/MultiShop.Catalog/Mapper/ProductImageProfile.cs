using AutoMapper;
using MultiShop.Catalog.Dtos.ProductImagesDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapper
{
	public class ProductImageProfile:Profile
	{
        public ProductImageProfile()
        {
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();
        }
    }
}
