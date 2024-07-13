namespace MShop.Business.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public required string CategoryName { get; set; }
        public string? Image { get; set; }
        public required ICollection<Product> Products { get; set; }

    }
}
