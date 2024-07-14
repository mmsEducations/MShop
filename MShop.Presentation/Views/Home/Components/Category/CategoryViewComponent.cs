namespace MShop.Presentation.Views.Home.Components.Category
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetCategoriesWithProducts();
            return View(categories);
        }
    }


}
