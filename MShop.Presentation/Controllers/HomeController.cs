using Microsoft.AspNetCore.Mvc;
using MShop.Business.Services;

namespace MShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        //BaseURl/Home/Index
        [HttpGet]
        public IActionResult Index()
        {

            var vategories = _categoryService.GetCategories();
            return View(vategories);
        }


        [HttpGet]
        public IActionResult Detail()
        {

            var vategories = _categoryService.GetCategories();
            return View(vategories);
        }
    }
}
