using MShop.Data.Entities;

namespace MShop.Business
{
    public interface IProductService
    {
        Product GetProductById(int id);
        List<Product> GetProducts();
        bool InsertProduct(Product product);
    }
}