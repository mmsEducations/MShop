namespace MShop.Data.Entities
{
    public class ProductImage : BaseEntity
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public required string Image { get; set; }
        public Product Product { get; set; }
    }

}


