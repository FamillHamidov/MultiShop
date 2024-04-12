namespace MultiShop.Discount.Dtos
{
	public class CreateDiscountCouponDto
	{
		public string? Code { get; set; }
		public int Rate { get; set; }
		public bool IsValid { get; set; }
		public DateTime ValidDate { get; set; }
	}
}
