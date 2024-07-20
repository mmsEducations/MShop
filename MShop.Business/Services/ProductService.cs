
using MShop.Repository.Abstract;

namespace MShop.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public ProductService(IProductRepository productRepository, IMapper mapper, IConfiguration configuration)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public List<ProductDto> GetProducts()
        {
            var products = _productRepository.GetAllAsNoTracking();
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public ProductDto GetProductById(int id)
        {
            var product = _productRepository.Get(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

        public bool InsertProduct(ProductDto product)
        {
            var productEntity = _mapper.Map<Product>(product);
            return _productRepository.Add(productEntity);
        }

        public List<ProductDto> GetProductsByType(ProductType productType)
        {
            var productCountSection = _configuration.GetSection("ProductSettings:ProductsToTakeForCatalog").Value;
            int productCount = productCountSection != null ? int.Parse(productCountSection) : 8;
            List<Product> products = new List<Product>();
            products = _productRepository.GetProductsByType((int)productType, productCount);
            var productDtos = _mapper.Map<List<ProductDto>>(products);

            return productDtos;
        }

        public List<ProductDto> GetProductsByCategoriId(int categoryId)
        {
            var products = _productRepository.GetProductsByCategoriId(categoryId);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }


        public ProductDto GetProductWithIncludeById(int id)
        {
            var product = _productRepository.GetProductWithIncludeById(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }


        public ProductDetailDto GetProductAndSimilarProductsById(int id)
        {
            var product = GetProductWithIncludeById(id);

            var productDetailPageSimilarProductsCount = _configuration.GetSection("ProductSettings:ProductDetailPageSimilarProductsTakeCount").Value;
            int similarProductsCount = productDetailPageSimilarProductsCount != null ? int.Parse(productDetailPageSimilarProductsCount) : 8;
            var products = _productRepository.GetProductAndSimilarProductsById(product.CategoryId, similarProductsCount);

            var similarProducts = _mapper.Map<List<ProductDto>>(products);
            //Yorum 
            product.ProducCommentAvg = GetProductRatingAvg(id);

            return ProductDetailDto.Create(product, similarProducts);
        }

        public short GetProductRatingAvg(int id)
        {
            return _productRepository.GetProductRatingAvg(id);

        }

    }

}
