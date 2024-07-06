namespace MShop.Data.Entities
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public required string Image { get; set; }
        public required Product Product { get; set; }
    }

}


