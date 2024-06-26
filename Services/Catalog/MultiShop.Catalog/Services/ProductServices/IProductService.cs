﻿using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
	public interface IProductService
	{
		Task<List<ResultProductDto>> GetAllProductAsync();
		Task UpdateProductAsync(UpdateProductDto updateProductDto);
		Task CreateProductAsync(CreateProductDto createProductDto);
		Task DeleteProductAsync(string id);
		Task<GetByIdProductDto> GetByIdProductAsync(string id);
	}
}
