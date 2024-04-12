﻿namespace MultiShop.Discount.Dtos
{
	public class GetByIdDiscountCouponDto
	{
		public int CouponId { get; set; }
		public string? Code { get; set; }
		public int Rate { get; set; }
		public bool IsValid { get; set; }
		public DateTime ValidDate { get; set; }
	}
}