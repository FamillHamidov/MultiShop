using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos;
using MultiShop.Discount.Service;

namespace MultiShop.Discount.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DiscountCouponController : ControllerBase
	{
		private readonly IDiscountService _discountService;

		public DiscountCouponController(IDiscountService discountService)
		{
			_discountService = discountService;
		}
		[HttpGet]
		public async Task<IActionResult> DiscountCouponList()
		{
			var values=await _discountService.GetAllDiscountCouponAsync();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetDiscountCouponById(int id)
		{
			var values=await _discountService.GetByIdDiscountCouponAsync(id);
			return Ok(values);	
		}
		[HttpPost]
		public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto createDiscountCouponDto)
		{
			await _discountService.CreateDiscountCouponAsync(createDiscountCouponDto);
			return Ok("Discount Coupon added successfuly");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteDiscountCoupon(int id)
		{
			await _discountService.DeleteDiscountCouponAsync(id);
			return Ok("Discount Coupon deleted successfuly");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
		{
			await _discountService.UpdateDiscountCouponAsync(updateDiscountCouponDto);
			return Ok("Discount Coupon updated successfuly");
		}
	}
}
