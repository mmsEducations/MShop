namespace MShop.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetProductByCategory(int id)
        {
            var productDtos = _productService.GetProductsByCategoriId(id);
            return View(productDtos);
        }
    }
}
