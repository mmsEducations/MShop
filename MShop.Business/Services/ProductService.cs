using MShop.Data;
using MShop.Data.Entities;

namespace MShop.Business
{
    public class ProductService : IProductService
    {
        private readonly MShopContext _context;
        public ProductService(MShopContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product GetProductById(int id)
        {
            var product = _context.Products
                                   .Where(c => c.ProductId == id)
                                   .FirstOrDefault();
            return product;
        }

        public bool InsertProduct(Product product)
        {
            _context.Products.Add(product);
            return _context.SaveChanges() > 0;
        }

    }

}
