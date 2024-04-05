using AutoMapper;
using MultiShop.Catalog.Dtos.ProductDetailsDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapper
{
	public class ProductDetailProfile:Profile
	{
        public ProductDetailProfile()
        {
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();
        }
    }
}
