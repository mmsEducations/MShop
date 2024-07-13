namespace MShop.Business.Dtos
{
    public class ProductDto//SliderModel
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string MainDescription { get; set; }
        public string? Description { get; set; }
        public string? Information { get; set; }
        public decimal Price { get; set; }
        public decimal? MarketPrice { get; set; }
        public short StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public required Category Category { get; set; }
        public required ICollection<ProductImage> ProductImages { get; set; }
        public required ICollection<ProductComment> ProductComments { get; set; }
    }
}
