using Dapper;
using MultiShop.Discount.Context;
using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Service
{
	public class DiscountService : IDiscountService
	{
		private readonly DapperContext _dapperContext;

		public DiscountService(DapperContext dapperContext)
		{
			_dapperContext = dapperContext;
		}

		public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto)
		{
			string query = "Insert into Coupons (Code, Rate, IsValid, ValidDate) values (@code, @rate, @isValid, @validDate)";
			var parameters = new DynamicParameters();
			parameters.Add("@code", createCouponDto.Code);
			parameters.Add("@rate", createCouponDto.Rate);
			parameters.Add("@isValid", createCouponDto.IsValid);
			parameters.Add("@validDate", createCouponDto.ValidDate);
			using(var connection=_dapperContext.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
		public async Task DeleteDiscountCouponAsync(int id)
		{
			string query = "Delete from Coupons Where CouponId=@couponId";
			var parameters = new DynamicParameters();
			parameters.Add("@couponId", id);
			using (var connection=_dapperContext.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
		public async Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync()
		{
			string query = "Select * From Coupons";
			using(var connection = _dapperContext.CreateConnection())
			{
				var value=await connection.QueryAsync<ResultDiscountCouponDto>(query);
				return value.ToList();
			}
		}
		public async Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id)
		{
			string query = "Select * From Coupons Where CouponId=@couponId";
			var parameters = new DynamicParameters();
			parameters.Add("@couponId", id);
			using(var connections = _dapperContext.CreateConnection())
			{
				return await connections.QueryFirstOrDefaultAsync<GetByIdDiscountCouponDto>(query, parameters);
			}
		}

		public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto)
		{
			string query = "Update Coupons Set Code=@code, Rate=@rate, IsValid=@isValid, ValidDate=@validDate Where CouponId=@couponId";
			var parameters = new DynamicParameters();
			parameters.Add("@code", updateCouponDto.Code);
			parameters.Add("@rate", updateCouponDto.Rate);
			parameters.Add("@isValid", updateCouponDto.IsValid);
			parameters.Add("@validDate", updateCouponDto.ValidDate);
			parameters.Add("@couponId", updateCouponDto.CouponId);
			using(var connection= _dapperContext.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
	}
}
