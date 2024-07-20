using Microsoft.EntityFrameworkCore;
using MShop.Data;
using MShop.Data.Entities;
using MShop.Repository.Abstract;

namespace MShop.Repository.Concrate
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MShopContext context) : base(context)
        {
        }

        public List<Product> GetProductAndSimilarProductsById(int productCategoryId, int similarProductsCount)
        {
            return _context.Products
                                    .Where(c => c.CategoryId == productCategoryId)
                                    .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .Take(similarProductsCount)
                                   .ToList();
        }

        public short GetProductRatingAvg(int id)
        {
            short avegrage = Convert.ToInt16(
                                       _context.ProductComments
                                      .Where(x => x.ProductId == id)
                                      .Average(x => x.Rating));

            return avegrage;
        }

        public List<Product> GetProductsByCategoriId(int categoryId)
        {
            var products = _context.Products
                                   .Where(c => c.CategoryId == categoryId)
                                   .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .Include(x => x.Category)
                                  .ToList();
            return products;
        }

        public List<Product> GetProductsByType(int productType, int productCount)
        {
            if (productType == 1)
            {
                return _context.Products
                                          .Where(x => x.IsShowCatalog)
                                          .Include(x => x.ProductComments)
                                          .Include(x => x.ProductImages)
                                          .Take(productCount).ToList();
            }
            else
            {
                return _context.Products
                                   .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .OrderByDescending(x => x.CreationDate)
                                   .Take(productCount).ToList();
            }


        }

        public Product? GetProductWithIncludeById(int id)
        {
            Product? product = _context.Products
                                   .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .Where(c => c.ProductId == id)
                                   .FirstOrDefault();

            return product;
        }
    }
}
