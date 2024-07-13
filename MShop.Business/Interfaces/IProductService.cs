using MShop.Business.Enums;

namespace MShop.Business
{
    public interface IProductService
    {
        ProductDto GetProductById(int id);
        List<ProductDto> GetProducts();
        bool InsertProduct(ProductDto product);

        List<ProductDto> GetProductsByType(ProductType productType);
    }
}