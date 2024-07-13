namespace MShop.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetProductByCategory(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return View(category);
        }
    }
}
