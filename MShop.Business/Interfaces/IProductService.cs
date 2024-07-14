
namespace MShop.Business
{
    public interface IProductService
    {
        ProductDto GetProductById(int id);
        List<ProductDto> GetProducts();
        bool InsertProduct(ProductDto product);

        List<ProductDto> GetProductsByType(ProductType productType);

        List<ProductDto> GetProductsByCategoriId(int id);


        ProductDetailDto GetProductAndSimilarProductsById(int id);

        short GetProductRatingAvg(int id);

    }
}