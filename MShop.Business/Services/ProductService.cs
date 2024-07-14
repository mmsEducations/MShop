
namespace MShop.Business
{
    public class ProductService : IProductService
    {
        private readonly MShopContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public ProductService(MShopContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
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
            var productCountSection = _configuration.GetSection("ProductSettings:ProductsToTakeForCatalog").Value;
            int productCount = productCountSection != null ? int.Parse(productCountSection) : 8;
            List<Product> products = new List<Product>();
            if (productType == ProductType.CatalogProducts)
            {
                products = _context.Products
                                          .Where(x => x.IsShowCatalog)
                                          .Include(x => x.ProductComments)
                                          .Include(x => x.ProductImages)
                                          .Take(productCount).ToList();
            }
            else
            {
                products = _context.Products
                                   .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .OrderByDescending(x => x.CreationDate)
                                   .Take(productCount).ToList();
            }


            var productDtos = _mapper.Map<List<ProductDto>>(products);

            return productDtos;
        }

        public List<ProductDto> GetProductsByCategoriId(int categoryId)
        {
            var products = _context.Products
                                    .Where(c => c.CategoryId == categoryId)
                                    .Include(x => x.ProductComments)
                                    .Include(x => x.ProductImages)
                                    .Include(x => x.Category)
                                   .ToList();

            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }


        public ProductDto GetProductWithIncludeById(int id)
        {
            var product = _context.Products
                                   .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .Where(c => c.ProductId == id)
                                   .FirstOrDefault();

            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }


        public ProductDetailDto GetProductAndSimilarProductsById(int id)
        {
            var product = GetProductWithIncludeById(id);

            var productDetailPageSimilarProductsCount = _configuration.GetSection("ProductSettings:ProductDetailPageSimilarProductsTakeCount").Value;
            int similarProductsCount = productDetailPageSimilarProductsCount != null ? int.Parse(productDetailPageSimilarProductsCount) : 8;

            var products = _context.Products
                                    .Where(c => c.CategoryId == product.CategoryId)
                                    .Include(x => x.ProductComments)
                                   .Include(x => x.ProductImages)
                                   .Take(similarProductsCount)
                                   .ToList();

            var similarProducts = _mapper.Map<List<ProductDto>>(products);

            //Yorum 
            product.ProducCommentAvg = GetProductRatingAvg(id);

            return ProductDetailDto.Create(product, similarProducts);
        }

        public short GetProductRatingAvg(int id)
        {
            short avegrage = Convert.ToInt16(
                             _context.ProductComments
                            .Where(x => x.ProductId == id)
                            .Average(x => x.Rating));

            return avegrage;

        }

    }

}
