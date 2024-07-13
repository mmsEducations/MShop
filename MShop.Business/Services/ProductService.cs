using Microsoft.EntityFrameworkCore;
using MShop.Business.Enums;

namespace MShop.Business
{
    public class ProductService : IProductService
    {
        private readonly MShopContext _context;
        private readonly IMapper _mapper;
        public ProductService(MShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ProductDto> GetProducts()
        {
            var products = _context.Products.ToList();
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public ProductDto GetProductById(int id)
        {
            var product = _context.Products
                                   .Where(c => c.ProductId == id)
                                   .FirstOrDefault();

            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

        public bool InsertProduct(ProductDto product)
        {
            var productEntity = _mapper.Map<Product>(product);

            _context.Products.Add(productEntity);
            return _context.SaveChanges() > 0;
        }


        public List<ProductDto> GetProductsByType(ProductType productType)
        {

            List<Product> products = new List<Product>();
            if (productType == ProductType.CatalogProducts)
            {
                products = _context.Products
                                          .Include(x => x.ProductComments)
                                          .Include(x => x.ProductImages)
                                          .Take(20).ToList();
            }
            else
            {
                products = _context.Products
                                   .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .OrderByDescending(x => x.CreationDate)
                                   .Take(20).ToList();
            }


            var productDtos = _mapper.Map<List<ProductDto>>(products);

            return productDtos;
        }
    }

}
