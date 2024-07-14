namespace MShop.Presentation.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Product/Detail
        public IActionResult Detail(int id)
        {
            ProductDetailDto productDetaildto = _productService.GetProductAndSimilarProductsById(id);
            //var res = _productService.GetProductRatingAvg(id);
            return View(productDetaildto);
        }
    }


}
