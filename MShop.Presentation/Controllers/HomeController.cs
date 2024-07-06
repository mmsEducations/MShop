using Microsoft.AspNetCore.Mvc;
using MShop.Business;
using MShop.Data;

namespace MShop.Presentation.Controllers
{
    public class HomeController : Controller
    {

        private readonly MShopContext _context;


        private readonly ICategoryService _categoryService;
        private readonly ISliderService _sliderService;
        public HomeController(ICategoryService categoryService, MShopContext context, ISliderService sliderService)
        {
            _categoryService = categoryService;
            _context = context;
            _sliderService = sliderService;
        }

        //BaseURl/Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            var sliders = _sliderService.GetSliders();

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
