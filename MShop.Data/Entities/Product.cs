namespace MShop.Data.Entities
{
    public class Product : BaseEntity
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
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
        public bool IsShowCatalog { get; set; }

    }

}


