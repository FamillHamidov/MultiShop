using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Services.CategoryServices
{
	public interface ICategoryService
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();
		Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
		Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
		Task DeleteCategoryAsync(string id);
		Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
	}
}
