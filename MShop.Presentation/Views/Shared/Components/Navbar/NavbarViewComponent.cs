namespace MShop.Presentation.Views.Shared.Components.Navbar
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public NavbarViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetCategories();
            return View(categories);
        }
    }
}
