using MShop.Data.Entities;

namespace MShop.Repository.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetProductsByCategoriId(int categoryId);

        Product? GetProductWithIncludeById(int id);

        short GetProductRatingAvg(int id);

        List<Product> GetProductsByType(int productType, int productCount);

        List<Product> GetProductAndSimilarProductsById(int productCategoryId, int similarProductsCount);
    }
}
