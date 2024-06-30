using Microsoft.AspNetCore.Mvc;
using MShop.Business;
using MShop.Data;

namespace MShop.Presentation.Controllers
{
    public class HomeController : Controller
    {

        private readonly MShopContext _context;


        private readonly ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService, MShopContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        //BaseURl/Home/Index
        [HttpGet]
        public IActionResult Index()
        {

            var vategories = _context.Categories.ToList();
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
