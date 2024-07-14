namespace MShop.Business.Dtos
{
    public class ProductDetailDto
    {
        public ProductDto Product { get; set; }
        public List<ProductDto> Products { get; set; }

        public static ProductDetailDto Create(ProductDto product, List<ProductDto> products)
        {
            return new ProductDetailDto()
            {
                Product = product,
                Products = products
            };
        }
    }
}
